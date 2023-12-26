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
        public string pID, pName;
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
                this.Close();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}