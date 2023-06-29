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
            this.FeedupBtn = new System.Windows.Forms.PictureBox();
            this.FeedBackBtn = new System.Windows.Forms.PictureBox();
            this.FeedForwardBtn = new System.Windows.Forms.PictureBox();
            this.AnimalPIc = new System.Windows.Forms.PictureBox();
            this.HealthBar = new System.Windows.Forms.ProgressBar();
            this.HappyBar = new System.Windows.Forms.ProgressBar();
            this.EvoBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.FeedupBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedBackBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedForwardBtn)).BeginInit();
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
            // 
            // FeedupBtn
            // 
            this.FeedupBtn.BackColor = System.Drawing.Color.Transparent;
            this.FeedupBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FeedupBtn.Image = global::FeedbufGame.Properties.Resources.Button;
            this.FeedupBtn.Location = new System.Drawing.Point(622, 752);
            this.FeedupBtn.Name = "FeedupBtn";
            this.FeedupBtn.Size = new System.Drawing.Size(215, 167);
            this.FeedupBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FeedupBtn.TabIndex = 1;
            this.FeedupBtn.TabStop = false;
            // 
            // FeedBackBtn
            // 
            this.FeedBackBtn.BackColor = System.Drawing.Color.Transparent;
            this.FeedBackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FeedBackBtn.Image = global::FeedbufGame.Properties.Resources.Button;
            this.FeedBackBtn.Location = new System.Drawing.Point(1246, 752);
            this.FeedBackBtn.Name = "FeedBackBtn";
            this.FeedBackBtn.Size = new System.Drawing.Size(215, 167);
            this.FeedBackBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FeedBackBtn.TabIndex = 2;
            this.FeedBackBtn.TabStop = false;
            // 
            // FeedForwardBtn
            // 
            this.FeedForwardBtn.BackColor = System.Drawing.Color.Transparent;
            this.FeedForwardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FeedForwardBtn.Image = global::FeedbufGame.Properties.Resources.Button;
            this.FeedForwardBtn.Location = new System.Drawing.Point(937, 752);
            this.FeedForwardBtn.Name = "FeedForwardBtn";
            this.FeedForwardBtn.Size = new System.Drawing.Size(215, 167);
            this.FeedForwardBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FeedForwardBtn.TabIndex = 3;
            this.FeedForwardBtn.TabStop = false;
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
            this.HappyBar.ForeColor = System.Drawing.Color.Yellow;
            this.HappyBar.Location = new System.Drawing.Point(22, 43);
            this.HappyBar.Name = "HappyBar";
            this.HappyBar.Size = new System.Drawing.Size(245, 23);
            this.HappyBar.TabIndex = 6;
            // 
            // EvoBar
            // 
            this.EvoBar.ForeColor = System.Drawing.Color.LimeGreen;
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
            this.Controls.Add(this.FeedForwardBtn);
            this.Controls.Add(this.FeedBackBtn);
            this.Controls.Add(this.FeedupBtn);
            this.Controls.Add(this.FeedBtn);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Game";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tamagotchi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FeedupBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedBackBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedForwardBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalPIc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FeedBtn;
        private System.Windows.Forms.PictureBox FeedupBtn;
        private System.Windows.Forms.PictureBox FeedBackBtn;
        private System.Windows.Forms.PictureBox FeedForwardBtn;
        private System.Windows.Forms.PictureBox AnimalPIc;
        private System.Windows.Forms.ProgressBar HealthBar;
        private System.Windows.Forms.ProgressBar HappyBar;
        private System.Windows.Forms.ProgressBar EvoBar;
    }
}