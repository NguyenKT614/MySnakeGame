namespace SnakeGame
{
    partial class DataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            this.PlayerID = new System.Windows.Forms.TextBox();
            this.PlayerName = new System.Windows.Forms.TextBox();
            this.PlayerIDtxt = new System.Windows.Forms.Label();
            this.PlayerNametxt = new System.Windows.Forms.Label();
            this.OKbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerID
            // 
            this.PlayerID.BackColor = System.Drawing.Color.LightSalmon;
            this.PlayerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerID.Location = new System.Drawing.Point(380, 123);
            this.PlayerID.Multiline = true;
            this.PlayerID.Name = "PlayerID";
            this.PlayerID.Size = new System.Drawing.Size(219, 59);
            this.PlayerID.TabIndex = 0;
            // 
            // PlayerName
            // 
            this.PlayerName.BackColor = System.Drawing.Color.LightSalmon;
            this.PlayerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerName.Location = new System.Drawing.Point(380, 257);
            this.PlayerName.Multiline = true;
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(219, 59);
            this.PlayerName.TabIndex = 0;
            // 
            // PlayerIDtxt
            // 
            this.PlayerIDtxt.AutoSize = true;
            this.PlayerIDtxt.BackColor = System.Drawing.Color.LightSalmon;
            this.PlayerIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerIDtxt.Location = new System.Drawing.Point(133, 137);
            this.PlayerIDtxt.Name = "PlayerIDtxt";
            this.PlayerIDtxt.Size = new System.Drawing.Size(138, 25);
            this.PlayerIDtxt.TabIndex = 1;
            this.PlayerIDtxt.Text = "Nhập PlayerID";
            // 
            // PlayerNametxt
            // 
            this.PlayerNametxt.AutoSize = true;
            this.PlayerNametxt.BackColor = System.Drawing.Color.LightSalmon;
            this.PlayerNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNametxt.Location = new System.Drawing.Point(133, 270);
            this.PlayerNametxt.Name = "PlayerNametxt";
            this.PlayerNametxt.Size = new System.Drawing.Size(171, 25);
            this.PlayerNametxt.TabIndex = 1;
            this.PlayerNametxt.Text = "Nhập PlayerName";
            // 
            // OKbutton
            // 
            this.OKbutton.BackColor = System.Drawing.Color.Salmon;
            this.OKbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OKbutton.Location = new System.Drawing.Point(283, 353);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(113, 47);
            this.OKbutton.TabIndex = 2;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = false;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.PlayerNametxt);
            this.Controls.Add(this.PlayerIDtxt);
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.PlayerID);
            this.Name = "DataForm";
            this.Text = "Player Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PlayerID;
        private System.Windows.Forms.TextBox PlayerName;
        private System.Windows.Forms.Label PlayerIDtxt;
        private System.Windows.Forms.Label PlayerNametxt;
        private System.Windows.Forms.Button OKbutton;
    }
}