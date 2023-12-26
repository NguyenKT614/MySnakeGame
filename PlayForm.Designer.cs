﻿namespace SnakeGame
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.easyRadioButton = new System.Windows.Forms.RadioButton();
            this.exitButton = new System.Windows.Forms.Button();
            this.dataButton = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.rankButton = new System.Windows.Forms.Button();
            this.hardRadioButton = new System.Windows.Forms.RadioButton();
            this.speedLabel = new System.Windows.Forms.Label();
            this.modeLabel = new System.Windows.Forms.Label();
            this.Mode1CheckBox = new System.Windows.Forms.CheckBox();
            this.Mode2CheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Salmon;
            this.startButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.startButton.Location = new System.Drawing.Point(842, 386);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.snapButton.Location = new System.Drawing.Point(843, 443);
            this.snapButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txtScore.Location = new System.Drawing.Point(840, 278);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(56, 16);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(840, 616);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Press \'P\' to pause";
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.mediumRadioButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mediumRadioButton.Location = new System.Drawing.Point(842, 72);
            this.mediumRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(160, 36);
            this.mediumRadioButton.TabIndex = 15;
            this.mediumRadioButton.Text = "Medium";
            this.mediumRadioButton.UseVisualStyleBackColor = false;
            this.mediumRadioButton.CheckedChanged += new System.EventHandler(this.mediumRadioButton_CheckedChanged);
            // 
            // easyRadioButton
            // 
            this.easyRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.easyRadioButton.Checked = true;
            this.easyRadioButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.easyRadioButton.Location = new System.Drawing.Point(843, 39);
            this.easyRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.easyRadioButton.Name = "easyRadioButton";
            this.easyRadioButton.Size = new System.Drawing.Size(160, 36);
            this.easyRadioButton.TabIndex = 16;
            this.easyRadioButton.TabStop = true;
            this.easyRadioButton.Text = "Easy";
            this.easyRadioButton.UseVisualStyleBackColor = false;
            this.easyRadioButton.CheckedChanged += new System.EventHandler(this.easyRadioButton_CheckedChanged);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Salmon;
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitButton.Location = new System.Drawing.Point(843, 557);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.dataButton.Location = new System.Drawing.Point(842, 332);
            this.dataButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataButton.Name = "dataButton";
            this.dataButton.Size = new System.Drawing.Size(168, 36);
            this.dataButton.TabIndex = 0;
            this.dataButton.Text = "Login";
            this.dataButton.UseVisualStyleBackColor = false;
            this.dataButton.Click += new System.EventHandler(this.EnterData);
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.SlateBlue;
            this.picCanvas.Image = ((System.Drawing.Image)(resources.GetObject("picCanvas.Image")));
            this.picCanvas.Location = new System.Drawing.Point(16, 15);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(811, 633);
            this.picCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCanvas.TabIndex = 1;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphics);
            // 
            // rankButton
            // 
            this.rankButton.BackColor = System.Drawing.Color.Salmon;
            this.rankButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rankButton.Location = new System.Drawing.Point(843, 500);
            this.rankButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rankButton.Name = "rankButton";
            this.rankButton.Size = new System.Drawing.Size(168, 36);
            this.rankButton.TabIndex = 0;
            this.rankButton.Text = "Show Data";
            this.rankButton.UseVisualStyleBackColor = false;
            this.rankButton.Click += new System.EventHandler(this.rankButton_Click);
            // 
            // hardRadioButton
            // 
            this.hardRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.hardRadioButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.hardRadioButton.Location = new System.Drawing.Point(842, 107);
            this.hardRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hardRadioButton.Name = "hardRadioButton";
            this.hardRadioButton.Size = new System.Drawing.Size(160, 36);
            this.hardRadioButton.TabIndex = 15;
            this.hardRadioButton.Text = "Hard";
            this.hardRadioButton.UseVisualStyleBackColor = false;
            this.hardRadioButton.CheckedChanged += new System.EventHandler(this.hardRadioButton_CheckedChanged);
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.speedLabel.Location = new System.Drawing.Point(839, 15);
            this.speedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(48, 16);
            this.speedLabel.TabIndex = 17;
            this.speedLabel.Text = "Speed";
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.modeLabel.Location = new System.Drawing.Point(839, 161);
            this.modeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(42, 16);
            this.modeLabel.TabIndex = 17;
            this.modeLabel.Text = "Mode";
            // 
            // Mode1CheckBox
            // 
            this.Mode1CheckBox.AutoSize = true;
            this.Mode1CheckBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Mode1CheckBox.Location = new System.Drawing.Point(842, 193);
            this.Mode1CheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Mode1CheckBox.Name = "Mode1CheckBox";
            this.Mode1CheckBox.Size = new System.Drawing.Size(145, 20);
            this.Mode1CheckBox.TabIndex = 18;
            this.Mode1CheckBox.Text = "Random Obstacles";
            this.Mode1CheckBox.UseVisualStyleBackColor = true;
            this.Mode1CheckBox.CheckedChanged += new System.EventHandler(this.Mode1CheckBox_CheckedChanged);
            // 
            // Mode2CheckBox
            // 
            this.Mode2CheckBox.AutoSize = true;
            this.Mode2CheckBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Mode2CheckBox.Location = new System.Drawing.Point(843, 230);
            this.Mode2CheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Mode2CheckBox.Name = "Mode2CheckBox";
            this.Mode2CheckBox.Size = new System.Drawing.Size(125, 20);
            this.Mode2CheckBox.TabIndex = 18;
            this.Mode2CheckBox.Text = "Outer Obstacles";
            this.Mode2CheckBox.UseVisualStyleBackColor = true;
            this.Mode2CheckBox.CheckedChanged += new System.EventHandler(this.Mode2CheckBox_CheckedChanged);
            // 
            // SnakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1019, 662);
            this.Controls.Add(this.Mode2CheckBox);
            this.Controls.Add(this.Mode1CheckBox);
            this.Controls.Add(this.modeLabel);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.hardRadioButton);
            this.Controls.Add(this.mediumRadioButton);
            this.Controls.Add(this.easyRadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.snapButton);
            this.Controls.Add(this.rankButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.dataButton);
            this.Controls.Add(this.startButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton mediumRadioButton;
        private System.Windows.Forms.RadioButton easyRadioButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button dataButton;
        private System.Windows.Forms.Button rankButton;
        private System.Windows.Forms.RadioButton hardRadioButton;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.CheckBox Mode1CheckBox;
        private System.Windows.Forms.CheckBox Mode2CheckBox;
    }
}

