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
        public static class MainMenuVar
        {
            public static bool first_timemenu = true;
        }
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
        private static DataForm dataForm;
        // Bắt đầu chơi 
        private void PlayButton_Click(object sender, EventArgs e)
        {
            // Ẩn MainMenu form khi ấn Play
            this.Hide();

            MainMenuVar.first_timemenu = false;

            dataForm = new DataForm();
            dataForm.Show();
        }
        public void DelInstance()
        {
            if (dataForm != null)
            {
                dataForm = null;
            }
        }
        // Tắt game
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
