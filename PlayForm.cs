using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;

namespace SnakeGame
{
    public partial class SnakeGame : Form
    {
        private static RankForm rankForm;
        private static DataForm dataForm;

        // Variable for Database
        DateTime pTime;
        string pID = "", pName = "";

        // Danh sách chứa con rắn
        private List<Circle> Snake = new List<Circle>();

        // Thức ăn
        private Circle food = new Circle();

        // Danh sách vật cản
        List<Obstacle> obstacles = new List<Obstacle>();

        // Các biến dùng cho mục đích setting chiều cao, chiều rộng của 1 đối tượng
        int maxWidth;
        int maxHeight;

        // Điểm số của người chơi
        int score;


        // Số lượng vật cản random
        int randomObstacleAmount = 20;

        /* 
         * Thời gian để tạo lại thức ăn
         * phòng trường hợp thức ăn ở vị trí mà các vật cản tạo thành chữ U
         * sẽ khiến người chơi không ăn được nên ta phải tạo lại
        */
        DateTime lastFoodTime;
        int foodTimeoutSeconds = 10;

        // count for pause
        // if count is even press P will pause
        // if count is odd press P will continue 
        int count = 0;

        Random rand = new Random();

        // biến định hướng di chuyển
        bool goLeft, goRight, goDown, goUp;

        // mode trò chơi
        bool mode1 = false;
        bool mode2 = false;

        // mode âm thanh
        bool music = true;
        bool sfx = true;


        private WaveOutEvent backgroundMusicPlayer;
        private WaveOutEvent eatSoundPlayer;
        private WaveOutEvent gameOverSoundPlayer;

        private AudioFileReader backgroundMusicReader;
        private AudioFileReader eatSoundReader;
        private AudioFileReader gameOverSoundReader;

        private string backgroundMusicPath = "C:/Users/NC/Downloads/conan.wav";
        private string eatSoundPath = "C:/Users/NC/Downloads/Eat_Sound.wav";
        private string gameOverSoundPath = "C:/Users/NC/Downloads/Game_Over_Sound.wav";

        // hàm khởi tạo khi instance được gọi
        public SnakeGame()
        {
            InitializeComponent();

            // Khởi tạo player cho nhạc nền
            backgroundMusicPlayer = new WaveOutEvent();
            backgroundMusicReader = new AudioFileReader(backgroundMusicPath);
            backgroundMusicPlayer.Init(backgroundMusicReader);
            // Tùy chỉnh âm lượng của âm thanh (0->1)
            backgroundMusicReader.Volume = 0.5f;

            // Khởi tạo player cho tiếng động khi con rắn ăn mồi
            eatSoundPlayer = new WaveOutEvent();
            eatSoundReader = new AudioFileReader(eatSoundPath);

            // Khởi tạo player cho âm thanh khi game over
            gameOverSoundPlayer = new WaveOutEvent();
            gameOverSoundReader = new AudioFileReader(gameOverSoundPath);
        }


        // Hàm khởi tạo vật cản ngẫu nhiên
        private void InitializeRandomObstacles()
        {
            // Create random obstacles 
            for (int i = 0; i < randomObstacleAmount; i++)
            {
                Obstacle newObstacle;
                do
                {
                    newObstacle = new Obstacle(rand.Next(0, maxWidth), rand.Next(0, maxHeight), 16, 16);
                } while (IsObstacleTooCloseToSnake(newObstacle));

                obstacles.Add(newObstacle);
            }
        }

        // Hàm khởi tạo vật cản ngẫu nhiên
        private void InitializeOuterObstacles()
        {
            // x ngang còn y dọc

            // Tạo vật cản rìa trên
            for (int i = 0; i < 38; i++)
            {
                Obstacle newObstacle;
                newObstacle = new Obstacle(i, 0, 16, 16); // y = 0
                obstacles.Add(newObstacle);
            }
            // Tạo vật cản rìa dưới
            for (int i = 0; i < 38; i++)
            {
                Obstacle newObstacle;
                newObstacle = new Obstacle(i, 31, 16, 16); // y = 31
                obstacles.Add(newObstacle);
            }
            // Tạo vật cản rìa trái
            for (int i = 1; i < 31; i++)
            {
                Obstacle newObstacle;
                newObstacle = new Obstacle(0, i, 16, 16); // x = 0
                obstacles.Add(newObstacle);
            }
            // Tạo vật cản rìa phải
            for (int i = 1; i < 31; i++)
            {
                Obstacle newObstacle;
                newObstacle = new Obstacle(37, i, 16, 16); // x = 37
                obstacles.Add(newObstacle);
            }
        }

        /* 
         * Xem vật cản có gần vị trí bắt đầu lúc start game không
         * (vì nếu gần quá sẽ dẫn đến thua ngay khi vừa vào game)
         */
        private bool IsObstacleTooCloseToSnake(Obstacle obstacle)
        {
            var SnakeHead = Snake[0];
            int distanceX = Math.Abs(SnakeHead.X - obstacle.X);

            // Kiểm tra xem vật cản có quá gần đầu rắn hay không
            if (distanceX < 4 && SnakeHead.Y == obstacle.Y)
            {
                return true;
            }
            return false;
        }

        // Khi nhấn 1 nút (nút di chuyển hoặc nút pause)
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            /* Nếu nhấn nút sang trái và hướng hiện tại không phải là di chuyển phải 
             * (không để cho đối tượng thực hiện quay đầu bằng các cắn vào bản thân)
             * nếu thỏa mãn thì sẽ đối tượng sang trái
             */
            if (e.KeyCode == Keys.Left && Settings.directions != "right")
                goLeft = true;
            if (e.KeyCode == Keys.Right && Settings.directions != "left")
                goRight = true;
            if (e.KeyCode == Keys.Up && Settings.directions != "down")
                goUp = true;
            if (e.KeyCode == Keys.Down && Settings.directions != "up")
                goDown = true;

            // Nếu nhấn P (pause), ta sẽ kiểm tra biến count
            if (e.KeyCode == Keys.P && count % 2 == 0)
            {
                gameTimer.Stop();
                count++;
            }
            else if (e.KeyCode == Keys.P && count % 2 == 1)
            {
                gameTimer.Start();
                count++;
            }
        }

        // Reset status to false to allow the next press to change to true
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                goLeft = false;
            if (e.KeyCode == Keys.Right)
                goRight = false;
            if (e.KeyCode == Keys.Up)
                goUp = false;
            if (e.KeyCode == Keys.Down)
                goDown = false;
        }

        // chấp nhân người chơi có được chơi hay không
        private int can_startGame = 0;

        // Dataform sẽ gửi dữ liệu khi được đóng
        private void DataForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataForm dataForm = sender as DataForm;
            if (dataForm != null)
            {
                this.pID = dataForm.pID;
                this.pName = dataForm.pName;
            }
        }

        // Yêu cầu người chơi nhập DataPlayer trước khi chơi game
        private void EnterData(object sender, EventArgs e)
        {
            dataForm = new DataForm();
            dataForm.FormClosed += DataForm_FormClosed;
            dataForm.Show();
            can_startGame = 1;
        }

        // Bắt đầu = Restart
        private void StartGame(object sender, EventArgs e)
        {
            if (can_startGame == 1)
            {
                RestartGame();
                can_startGame = 0;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Login để nhập thông tin người chơi!?", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        // Chụp hình 
        private void TakeSnapShot(object sender, EventArgs e)
        {
            Label caption = new Label();
            caption.Text = "I scored: " + score;
            caption.ForeColor = Color.White;
            caption.Font = new Font("Arial", 12, FontStyle.Bold);
            caption.AutoSize = false;
            caption.Width = picCanvas.Width;
            caption.Height = 30;
            caption.TextAlign = ContentAlignment.MiddleCenter;
            picCanvas.Controls.Add(caption);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "Snake Game Snapshot";
            dialog.DefaultExt = "jpg";
            dialog.Filter = "JPG Image File | *.jpg";
            dialog.ValidateNames = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(picCanvas.Width);
                int height = Convert.ToInt32(picCanvas.Height);
                Bitmap bmp = new Bitmap(width, height);
                picCanvas.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                bmp.Save(dialog.FileName, ImageFormat.Jpeg);
                picCanvas.Controls.Remove(caption);
            }

        }

        // Bộ đếm thời gian 
        private void GameTimerEvent(object sender, EventArgs e)
        {
            // Setting the directions
            if (goLeft)
            {
                Settings.directions = "left";
            }
            if (goRight)
            {
                Settings.directions = "right";
            }
            if (goDown)
            {
                Settings.directions = "down";
            }
            if (goUp)
            {
                Settings.directions = "up";
            }

            // End of directions
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                // For the head
                if (i == 0)
                {
                    switch (Settings.directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                    }


                    // Go to the other side
                    // if hit walls
                    if (Snake[i].X < 0)
                    {
                        Snake[i].X = maxWidth;
                    }
                    if (Snake[i].X > maxWidth)
                    {
                        Snake[i].X = 0;
                    }
                    if (Snake[i].Y < 0)
                    {
                        Snake[i].Y = maxHeight;
                    }
                    if (Snake[i].Y > maxHeight)
                    {
                        Snake[i].Y = 0;
                    }


                    // Kiểm tra va chạm với các đối tượng vật cản
                    foreach (var obstacle in obstacles)
                    {
                        // Trục x chạy từ trái qua phải
                        // Trục y chạy từ trên xuống dưới

                        // Kiểm tra xem đầu rắn có nằm trong vùng diện tích của vật cản không
                        if (Snake[0].Y == obstacle.Y && Snake[0].X == obstacle.X)
                        {
                            // Xử lý khi rắn va chạm với vật cản (ví dụ: kết thúc trò chơi)
                            GameOver();
                        }
                    }

                    // Kiểm tra xem đã đủ thời gian chưa để tạo food mới
                    if ((DateTime.Now - lastFoodTime).TotalSeconds >= foodTimeoutSeconds)
                    {
                        // Create new random food 
                        do
                            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
                        while (FoodOnBody() || FoodOnObstacle() || (FoodOnBody() && FoodOnObstacle()));

                        // Cập nhật thời gian tạo food lần cuối
                        lastFoodTime = DateTime.Now;
                    }

                    // When snake head meet the food
                    if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                    {
                        EatFood();
                    }

                    // When snake head meet its body
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[0].X == Snake[j].X && Snake[0].Y == Snake[j].Y)
                        {
                            GameOver();
                        }
                    }
                }

                // For the body
                // Make the body follow the head
                else if (i > 0)
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }

            // Delete the drawn frame to move to next frame
            // make things looks like they're moving
            picCanvas.Invalidate();
        }

        // Hiển thị hình ảnh của rắn
        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            TextureBrush snakeColour;

            // Fill color for snake
            for (int i = 0; i < Snake.Count; i++)
            {
                if (i == 0)
                {
                    Image snakeImage = Properties.Resources.dauran;
                    snakeColour = new TextureBrush(snakeImage);
                }
                else
                {
                    Image snakeImage = Properties.Resources.duoiran;
                    snakeColour = new TextureBrush(snakeImage);
                }


                canvas.FillRectangle(snakeColour, new Rectangle
                    (
                    Snake[i].X * Settings.Width,
                    Snake[i].Y * Settings.Height,
                    Settings.Width, Settings.Height
                    ));
            }

            Image foodImage = Properties.Resources.apple_removebg_preview;
            TextureBrush foodColour = new TextureBrush(foodImage);
            // Fill color for food
            canvas.FillRectangle(foodColour, new Rectangle
            (
            food.X * Settings.Width,
            food.Y * Settings.Height,
            Settings.Width, Settings.Height
            ));


            Image obstacleImage = Properties.Resources.therock_removebg_preview;
            TextureBrush obstacleColour = new TextureBrush(obstacleImage);
            // Vẽ các đối tượng vật cản
            foreach (var obstacle in obstacles)
            {
                canvas.FillRectangle(obstacleColour, new Rectangle
                    (
                    obstacle.X * obstacle.Width,
                    obstacle.Y * obstacle.Height,
                    obstacle.Width, obstacle.Height
                    ));
            }
        }


        // Hàm bắt đầu lại trò chơi
        private void RestartGame()
        {
            // Bắt đầu phát nhạc nền
            if (music)
            {
                backgroundMusicPlayer.Play();
            }

            new Settings();

            // Lấy dữ liệu thời gian chơi
            pTime = DateTime.Now;

            maxWidth = picCanvas.Width / Settings.Width - 1;
            maxHeight = picCanvas.Height / Settings.Height - 1;

            // Reset con rắn
            Snake.Clear();

            // Nếu Button enabled thì program sẽ auto focus vào button
            // khi đó thì không dùng các phim trên bàn phím dc nên phải tắt
            startButton.Enabled = false;
            snapButton.Enabled = false;

            easyRadioButton.Enabled = false;
            mediumRadioButton.Enabled = false;
            hardRadioButton.Enabled = false;

            Mode1CheckBox.Enabled = false;
            Mode2CheckBox.Enabled = false;

            musicCheckBox.Enabled = false;
            SFXCheckBox.Enabled = false;

            exitButton.Enabled = false;
            dataButton.Enabled = false;
            rankButton.Enabled = false;

            score = 0;
            txtScore.Text = "Score: " + score;

            // Adding the head part of the snake to the list
            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head);

            // Xóa vật cản cũ
            obstacles.Clear();

            // Khởi tạo vật cản 
            if (mode1)
                InitializeRandomObstacles();

            if (mode2)
                InitializeOuterObstacles();

            // Create and add the body part of the snake to the list
            for (int i = 0; i < 10; i++)
            {
                Circle body = new Circle();
                Snake.Add(body);
            }

            // Create random food and prevent it to spawn on the snake body
            do
                food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
            while (FoodOnBody() || FoodOnObstacle());

            // Đặt thời gian tạo food lần cuối
            lastFoodTime = DateTime.Now;

            // Start timer
            gameTimer.Start();
        }

        // Khi rắn đụng vào thức ăn
        private void EatFood()
        {
            // Phát tiếng động khi con rắn ăn mồi
            if (sfx)
            {
                eatSoundPlayer.Stop(); // Dừng player nếu đang phát
                eatSoundPlayer.Init(new AudioFileReader(eatSoundPath)); // Khởi tạo lại để chuẩn bị phát
                eatSoundPlayer.Play(); // Bắt đầu phát
            }

            // Tăng điểm lên 1
            score += 1;
            txtScore.Text = "Score: " + score;

            // Tạo 1 đơn vị body cho thân rắn
            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            // Thêm phần thân vừa tạo vào List rắn
            Snake.Add(body);

            // Create random food 
            do
                food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
            while (FoodOnBody() || FoodOnObstacle() || (FoodOnBody() && FoodOnObstacle()));

            // Cập nhật thời gian tạo food lần cuối
            lastFoodTime = DateTime.Now;
        }

        private void easyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gameTimer.Interval = 80;
        }

        private void mediumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gameTimer.Interval = 70;
        }

        private void hardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gameTimer.Interval = 60;
        }
        private void rankButton_Click(object sender, EventArgs e)
        {
            rankForm = new RankForm();
            rankForm.Show();
        }

        private void Mode1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Mode1CheckBox.Checked)
            {
                mode1 = true;
            }
            else
            {
                mode1 = false;
            }
        }

        private void Mode2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Mode2CheckBox.Checked)
            {
                mode2 = true;
            }
            else
            {
                mode2 = false;
            }
        }

        private void musicCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (musicCheckBox.Checked)
            {
                music = true;
            }
            else
            {
                music = false;
            }
        }

        private void SFXCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SFXCheckBox.Checked)
            {
                sfx = true;
            }
            else
            {
                sfx = false;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Kiểm tra xem food có nằm TRÙNG vị trí của body hay không
        bool FoodOnBody()
        {
            for (int i = 0; i < Snake.Count; i++)
            {
                if (food.X == Snake[i].X && food.Y == Snake[i].Y)
                    return true;
            }
            return false;
        }

        // Kiểm tra xem food có đang ở trên vật cản hay không, nếu có thì không thể được
        bool FoodOnObstacle()
        {
            // Nếu người chơi có chọn mở mode vật cản thì mới kiểm tra
            if (mode1 || mode2)
                for (int i = 0; i < obstacles.Count; i++)
                {
                    if (food.X == obstacles[i].X && food.Y == obstacles[i].Y)
                        return true;
                }

            // Nếu food ko nằm trên vật cản hoặc người chơi k chọn mode vật cản nào trì auto false
            return false;
        }

        // Xử lí khi game kết thúc
        private void GameOver()
        {
            // Dừng nhạc nền
            backgroundMusicPlayer.Stop();

            if (sfx)
            {
                // Phát âm thanh khi game over
                gameOverSoundPlayer.Stop();
                gameOverSoundPlayer.Init(new AudioFileReader(gameOverSoundPath));
                gameOverSoundPlayer.Play();
            }

            gameTimer.Stop();

            // Cho phép các button được bấm
            startButton.Enabled = true;
            snapButton.Enabled = true;

            easyRadioButton.Enabled = true;
            mediumRadioButton.Enabled = true;
            hardRadioButton.Enabled = true;

            Mode1CheckBox.Enabled = true;
            Mode2CheckBox.Enabled = true;

            musicCheckBox.Enabled = true;
            SFXCheckBox.Enabled = true;

            exitButton.Enabled = true;
            dataButton.Enabled = true;
            rankButton.Enabled = true;

            // hiển thị form chứa thông tin kết quả của người chơi
            rankForm = new RankForm(pTime, pID, pName, score);
            rankForm.Show();

            // xóa instance dataForm
            dataForm = null;

        }
    }
}