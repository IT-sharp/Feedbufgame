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
            ((System.ComponentModel.ISupportInitialize)(this.FeedupBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedBackBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedForwardBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // FeedBtn
            // 
            this.FeedBtn.BackColor = System.Drawing.Color.LawnGreen;
            this.FeedBtn.Location = new System.Drawing.Point(1621, 23);
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
            this.FeedupBtn.Location = new System.Drawing.Point(499, 854);
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
            this.FeedBackBtn.Location = new System.Drawing.Point(787, 854);
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
            this.FeedForwardBtn.Location = new System.Drawing.Point(1073, 854);
            this.FeedForwardBtn.Name = "FeedForwardBtn";
            this.FeedForwardBtn.Size = new System.Drawing.Size(215, 167);
            this.FeedForwardBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FeedForwardBtn.TabIndex = 3;
            this.FeedForwardBtn.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FeedbufGame.Properties.Resources.Forest_png;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.FeedForwardBtn);
            this.Controls.Add(this.FeedBackBtn);
            this.Controls.Add(this.FeedupBtn);
            this.Controls.Add(this.FeedBtn);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Game";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Tamagotchi";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FeedupBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedBackBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedForwardBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FeedBtn;
        private System.Windows.Forms.PictureBox FeedupBtn;
        private System.Windows.Forms.PictureBox FeedBackBtn;
        private System.Windows.Forms.PictureBox FeedForwardBtn;
    }
}