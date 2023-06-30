namespace FeedbufGame
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
            ((System.ComponentModel.ISupportInitialize)(this.FeedBackForwardBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedTasksBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedupBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalPIc)).BeginInit();
            this.SuspendLayout();
            // 
            // FeedBtn
            // 
            this.FeedBtn.BackColor = System.Drawing.Color.LawnGreen;
            this.FeedBtn.Location = new System.Drawing.Point(1591, 43);
            this.FeedBtn.Name = "FeedBtn";
            this.FeedBtn.Size = new System.Drawing.Size(269, 82);
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
            this.FeedBackForwardBtn.Location = new System.Drawing.Point(622, 752);
            this.FeedBackForwardBtn.Name = "FeedBackForwardBtn";
            this.FeedBackForwardBtn.Size = new System.Drawing.Size(215, 167);
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
            this.FeedTasksBtn.Location = new System.Drawing.Point(1246, 752);
            this.FeedTasksBtn.Name = "FeedTasksBtn";
            this.FeedTasksBtn.Size = new System.Drawing.Size(215, 167);
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
            this.FeedupBtn.Location = new System.Drawing.Point(937, 752);
            this.FeedupBtn.Name = "FeedupBtn";
            this.FeedupBtn.Size = new System.Drawing.Size(215, 167);
            this.FeedupBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FeedupBtn.TabIndex = 3;
            this.FeedupBtn.TabStop = false;
            this.FeedupBtn.Click += new System.EventHandler(this.FeedupBtn_Click);
            // 
            // AnimalPIc
            // 
            this.AnimalPIc.BackColor = System.Drawing.Color.Transparent;
            this.AnimalPIc.Enabled = false;
            this.AnimalPIc.Location = new System.Drawing.Point(588, 159);
            this.AnimalPIc.Name = "AnimalPIc";
            this.AnimalPIc.Size = new System.Drawing.Size(1000, 500);
            this.AnimalPIc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AnimalPIc.TabIndex = 4;
            this.AnimalPIc.TabStop = false;
            // 
            // HealthBar
            // 
            this.HealthBar.ForeColor = System.Drawing.Color.Red;
            this.HealthBar.Location = new System.Drawing.Point(22, 13);
            this.HealthBar.Name = "HealthBar";
            this.HealthBar.Size = new System.Drawing.Size(245, 23);
            this.HealthBar.TabIndex = 5;
            // 
            // HappyBar
            // 
            this.HappyBar.ForeColor = System.Drawing.Color.Blue;
            this.HappyBar.Location = new System.Drawing.Point(22, 43);
            this.HappyBar.Name = "HappyBar";
            this.HappyBar.Size = new System.Drawing.Size(245, 23);
            this.HappyBar.TabIndex = 6;
            // 
            // EvoBar
            // 
            this.EvoBar.ForeColor = System.Drawing.Color.Yellow;
            this.EvoBar.Location = new System.Drawing.Point(22, 72);
            this.EvoBar.Name = "EvoBar";
            this.EvoBar.Size = new System.Drawing.Size(245, 23);
            this.EvoBar.TabIndex = 7;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FeedbufGame.Properties.Resources.Forest_png;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 965);
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
    }
}