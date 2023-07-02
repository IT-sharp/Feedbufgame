﻿namespace FeedbufGame
{
    partial class Game
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
            this.FeedBtn = new System.Windows.Forms.Button();
            this.FeedBackForwardBtn = new System.Windows.Forms.PictureBox();
            this.FeedTasksBtn = new System.Windows.Forms.PictureBox();
            this.FeedupBtn = new System.Windows.Forms.PictureBox();
            this.AnimalPIc = new System.Windows.Forms.PictureBox();
            this.HealthBar = new System.Windows.Forms.ProgressBar();
            this.HappyBar = new System.Windows.Forms.ProgressBar();
            this.EvoBar = new System.Windows.Forms.ProgressBar();
            this.ShopBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FeedBackForwardBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedTasksBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedupBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalPIc)).BeginInit();
            this.SuspendLayout();
            // 
            // FeedBtn
            // 
            this.FeedBtn.BackColor = System.Drawing.Color.LawnGreen;
            this.FeedBtn.Location = new System.Drawing.Point(1193, 35);
            this.FeedBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FeedBtn.Name = "FeedBtn";
            this.FeedBtn.Size = new System.Drawing.Size(202, 67);
            this.FeedBtn.TabIndex = 0;
            this.FeedBtn.Text = "All feed";
            this.FeedBtn.UseVisualStyleBackColor = false;
            this.FeedBtn.Click += new System.EventHandler(this.FeedBtn_Click);
            // 
            // FeedBackForwardBtn
            // 
            this.FeedBackForwardBtn.BackColor = System.Drawing.Color.Transparent;
            this.FeedBackForwardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FeedBackForwardBtn.Image = global::FeedbufGame.Properties.Resources.Button;
            this.FeedBackForwardBtn.Location = new System.Drawing.Point(466, 611);
            this.FeedBackForwardBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FeedBackForwardBtn.Name = "FeedBackForwardBtn";
            this.FeedBackForwardBtn.Size = new System.Drawing.Size(161, 136);
            this.FeedBackForwardBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FeedBackForwardBtn.TabIndex = 1;
            this.FeedBackForwardBtn.TabStop = false;
            this.FeedBackForwardBtn.Click += new System.EventHandler(this.FeedBackForwardBtn_Click);
            // 
            // FeedTasksBtn
            // 
            this.FeedTasksBtn.BackColor = System.Drawing.Color.Transparent;
            this.FeedTasksBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FeedTasksBtn.Image = global::FeedbufGame.Properties.Resources.Button;
            this.FeedTasksBtn.Location = new System.Drawing.Point(934, 611);
            this.FeedTasksBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FeedTasksBtn.Name = "FeedTasksBtn";
            this.FeedTasksBtn.Size = new System.Drawing.Size(161, 136);
            this.FeedTasksBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FeedTasksBtn.TabIndex = 2;
            this.FeedTasksBtn.TabStop = false;
            this.FeedTasksBtn.Click += new System.EventHandler(this.FeedTasksBtn_Click);
            // 
            // FeedupBtn
            // 
            this.FeedupBtn.BackColor = System.Drawing.Color.Transparent;
            this.FeedupBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FeedupBtn.Image = global::FeedbufGame.Properties.Resources.Button;
            this.FeedupBtn.Location = new System.Drawing.Point(703, 611);
            this.FeedupBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FeedupBtn.Name = "FeedupBtn";
            this.FeedupBtn.Size = new System.Drawing.Size(161, 136);
            this.FeedupBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FeedupBtn.TabIndex = 3;
            this.FeedupBtn.TabStop = false;
            this.FeedupBtn.Click += new System.EventHandler(this.FeedupBtn_Click);
            // 
            // AnimalPIc
            // 
            this.AnimalPIc.BackColor = System.Drawing.Color.Transparent;
            this.AnimalPIc.Enabled = false;
            this.AnimalPIc.Location = new System.Drawing.Point(221, 106);
            this.AnimalPIc.Margin = new System.Windows.Forms.Padding(2);
            this.AnimalPIc.Name = "AnimalPIc";
            this.AnimalPIc.Size = new System.Drawing.Size(1000, 500);
            this.AnimalPIc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AnimalPIc.TabIndex = 4;
            this.AnimalPIc.TabStop = false;
            // 
            // HealthBar
            // 
            this.HealthBar.ForeColor = System.Drawing.Color.Red;
            this.HealthBar.Location = new System.Drawing.Point(16, 11);
            this.HealthBar.Margin = new System.Windows.Forms.Padding(2);
            this.HealthBar.Name = "HealthBar";
            this.HealthBar.Size = new System.Drawing.Size(184, 19);
            this.HealthBar.TabIndex = 5;
            // 
            // HappyBar
            // 
            this.HappyBar.ForeColor = System.Drawing.Color.Blue;
            this.HappyBar.Location = new System.Drawing.Point(16, 35);
            this.HappyBar.Margin = new System.Windows.Forms.Padding(2);
            this.HappyBar.Name = "HappyBar";
            this.HappyBar.Size = new System.Drawing.Size(184, 19);
            this.HappyBar.TabIndex = 6;
            // 
            // EvoBar
            // 
            this.EvoBar.ForeColor = System.Drawing.Color.Yellow;
            this.EvoBar.Location = new System.Drawing.Point(16, 58);
            this.EvoBar.Margin = new System.Windows.Forms.Padding(2);
            this.EvoBar.Name = "EvoBar";
            this.EvoBar.Size = new System.Drawing.Size(184, 19);
            this.EvoBar.TabIndex = 7;
            // 
            // ShopBtn
            // 
            this.ShopBtn.BackColor = System.Drawing.Color.LawnGreen;
            this.ShopBtn.Location = new System.Drawing.Point(1307, 141);
            this.ShopBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ShopBtn.Name = "ShopBtn";
            this.ShopBtn.Size = new System.Drawing.Size(88, 62);
            this.ShopBtn.TabIndex = 8;
            this.ShopBtn.Text = "Shop";
            this.ShopBtn.UseVisualStyleBackColor = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FeedbufGame.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1426, 784);
            this.Controls.Add(this.ShopBtn);
            this.Controls.Add(this.EvoBar);
            this.Controls.Add(this.HappyBar);
            this.Controls.Add(this.HealthBar);
            this.Controls.Add(this.AnimalPIc);
            this.Controls.Add(this.FeedupBtn);
            this.Controls.Add(this.FeedTasksBtn);
            this.Controls.Add(this.FeedBackForwardBtn);
            this.Controls.Add(this.FeedBtn);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Game";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tamagotchi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FeedBackForwardBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedTasksBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedupBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalPIc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FeedBtn;
        private System.Windows.Forms.PictureBox FeedBackForwardBtn;
        private System.Windows.Forms.PictureBox FeedTasksBtn;
        private System.Windows.Forms.PictureBox FeedupBtn;
        private System.Windows.Forms.PictureBox AnimalPIc;
        private System.Windows.Forms.ProgressBar HealthBar;
        private System.Windows.Forms.ProgressBar HappyBar;
        private System.Windows.Forms.ProgressBar EvoBar;
        private System.Windows.Forms.Button ShopBtn;
    }
}