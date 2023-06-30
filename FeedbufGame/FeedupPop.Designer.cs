namespace FeedbufGame
{
    partial class FeedupPop
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
            this.feedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // feedButton
            // 
            this.feedButton.Location = new System.Drawing.Point(254, 340);
            this.feedButton.Name = "feedButton";
            this.feedButton.Size = new System.Drawing.Size(166, 60);
            this.feedButton.TabIndex = 2;
            this.feedButton.Text = "Give feed";
            this.feedButton.UseVisualStyleBackColor = true;
            // 
            // Feedup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 435);
            this.Controls.Add(this.feedButton);
            this.Name = "Feedup";
            this.Text = "Feedup";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button feedButton;
    }
}