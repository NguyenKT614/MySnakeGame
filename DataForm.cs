using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class DataForm : Form
    {
        DataForm dataForm;
        private MainMenuForm menuForm = new MainMenuForm();
        private SnakeGame snakeGameForm;
        string pID, pName;
        public DataForm()
        {
            InitializeComponent();
            PlayerIDtxt.BackColor = Color.Transparent;
            PlayerNametxt.BackColor = Color.Transparent;
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (PlayerID.Text == "" && PlayerName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!");
            }
            else
            {
                pID = PlayerID.Text;
                pName = PlayerName.Text;
                // Tạo một instance mới của form chơi game
                snakeGameForm = new SnakeGame(pID,pName);

                // Gắn sự kiện để hiển thị lại MainMenu form khi trò chơi kết thúc
                snakeGameForm.GameOverEvent += SnakeGameForm_GameOverEvent;

                // Mở form chơi game
                snakeGameForm.Show();

                this.Hide();
            }
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Sự kiện xảy ra khi trò chơi kết thúc
        private void SnakeGameForm_GameOverEvent()
        {
            // Xóa instance của dataform trước và snakegameform trước
            menuForm.DelInstance();
            snakeGameForm = null;
            // Hiển thị lại MainMenu form khi trò chơi kết thúc
            dataForm = new DataForm();
            dataForm.Show();
        }
    }
}
