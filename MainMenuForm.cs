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
