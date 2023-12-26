namespace SnakeGame
{
    partial class SnakeGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnakeGame));
            this.startButton = new System.Windows.Forms.Button();
            this.snapButton = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtHighScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.easyRadioButton = new System.Windows.Forms.RadioButton();
            this.exitButton = new System.Windows.Forms.Button();
            this.dataButton = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.rankButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Salmon;
            this.startButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.startButton.Location = new System.Drawing.Point(833, 280);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(168, 36);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartGame);
            // 
            // snapButton
            // 
            this.snapButton.BackColor = System.Drawing.Color.Salmon;
            this.snapButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.snapButton.Location = new System.Drawing.Point(833, 324);
            this.snapButton.Margin = new System.Windows.Forms.Padding(4);
            this.snapButton.Name = "snapButton";
            this.snapButton.Size = new System.Drawing.Size(168, 36);
            this.snapButton.TabIndex = 0;
            this.snapButton.Text = "Snap";
            this.snapButton.UseVisualStyleBackColor = false;
            this.snapButton.Click += new System.EventHandler(this.TakeSnapShot);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtScore.Location = new System.Drawing.Point(829, 169);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(56, 16);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Score: 0";
            // 
            // txtHighScore
            // 
            this.txtHighScore.AutoSize = true;
            this.txtHighScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtHighScore.Location = new System.Drawing.Point(829, 196);
            this.txtHighScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtHighScore.Name = "txtHighScore";
            this.txtHighScore.Size = new System.Drawing.Size(74, 16);
            this.txtHighScore.TabIndex = 2;
            this.txtHighScore.Text = "High Score";
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(843, 613);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Press \'P\' to pause";
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.mediumRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.mediumRadioButton.Location = new System.Drawing.Point(833, 69);
            this.mediumRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(160, 36);
            this.mediumRadioButton.TabIndex = 15;
            this.mediumRadioButton.Text = "Medium";
            this.mediumRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mediumRadioButton.UseVisualStyleBackColor = false;
            this.mediumRadioButton.CheckedChanged += new System.EventHandler(this.mediumRadioButton_CheckedChanged);
            // 
            // easyRadioButton
            // 
            this.easyRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.easyRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.easyRadioButton.Checked = true;
            this.easyRadioButton.Location = new System.Drawing.Point(833, 15);
            this.easyRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.easyRadioButton.Name = "easyRadioButton";
            this.easyRadioButton.Size = new System.Drawing.Size(160, 36);
            this.easyRadioButton.TabIndex = 16;
            this.easyRadioButton.TabStop = true;
            this.easyRadioButton.Text = "Easy";
            this.easyRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.easyRadioButton.UseVisualStyleBackColor = false;
            this.easyRadioButton.CheckedChanged += new System.EventHandler(this.easyRadioButton_CheckedChanged);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Salmon;
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitButton.Location = new System.Drawing.Point(833, 412);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(168, 36);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dataButton
            // 
            this.dataButton.BackColor = System.Drawing.Color.Salmon;
            this.dataButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataButton.Location = new System.Drawing.Point(833, 236);
            this.dataButton.Margin = new System.Windows.Forms.Padding(4);
            this.dataButton.Name = "dataButton";
            this.dataButton.Size = new System.Drawing.Size(168, 36);
            this.dataButton.TabIndex = 0;
            this.dataButton.Text = "Data";
            this.dataButton.UseVisualStyleBackColor = false;
            this.dataButton.Click += new System.EventHandler(this.EnterData);
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.SlateBlue;
            this.picCanvas.Image = ((System.Drawing.Image)(resources.GetObject("picCanvas.Image")));
            this.picCanvas.Location = new System.Drawing.Point(16, 15);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(805, 633);
            this.picCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCanvas.TabIndex = 1;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphics);
            // 
            // rankButton
            // 
            this.rankButton.BackColor = System.Drawing.Color.Salmon;
            this.rankButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rankButton.Location = new System.Drawing.Point(833, 368);
            this.rankButton.Margin = new System.Windows.Forms.Padding(4);
            this.rankButton.Name = "rankButton";
            this.rankButton.Size = new System.Drawing.Size(168, 36);
            this.rankButton.TabIndex = 0;
            this.rankButton.Text = "Show Data";
            this.rankButton.UseVisualStyleBackColor = false;
            this.rankButton.Click += new System.EventHandler(this.rankButton_Click);
            // 
            // SnakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1017, 662);
            this.Controls.Add(this.mediumRadioButton);
            this.Controls.Add(this.easyRadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHighScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.snapButton);
            this.Controls.Add(this.rankButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.dataButton);
            this.Controls.Add(this.startButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SnakeGame";
            this.Text = "Snake Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button snapButton;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtHighScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton mediumRadioButton;
        private System.Windows.Forms.RadioButton easyRadioButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button dataButton;
        private System.Windows.Forms.Button rankButton;
    }
}

