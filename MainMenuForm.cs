using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();

            // Đặt màu nền trong suốt cho Panel
            // (bỏ các control vào panel trong suốt sẽ khiến control có nền trong suốt)
            panel1.BackColor = Color.FromArgb(0, Color.White);
            panel2.BackColor = Color.FromArgb(0, Color.White);

            // Label âm thanh 
            Label soundLabel = new Label();
            soundLabel.Text = "Sound:";
            soundLabel.AutoSize = true;

            // Tạo check box tắt bật âm thanh
            CheckBox soundCheckBox = new CheckBox();
            soundCheckBox.Text = "On";
            soundCheckBox.AutoSize = true;

            // Add controls to respective panels
            panel1.Controls.Add(soundLabel);
            panel2.Controls.Add(soundCheckBox);

        }
        private DataForm dataForm;
        // Bắt đầu chơi 
        private void PlayButton_Click(object sender, EventArgs e)
        {
            // Ẩn MainMenu form khi ấn Play
            this.Hide();

            dataForm = new DataForm();
            dataForm.Show();
        }

        // Tắt game
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
