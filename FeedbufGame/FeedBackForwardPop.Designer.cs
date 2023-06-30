namespace FeedbufGame
{
    partial class FeedBackForwardPop
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
            this.CbBackForward = new System.Windows.Forms.ComboBox();
            this.feedButton = new System.Windows.Forms.Button();
            this.TbCommentaryFeedBF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbTeacher = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpFeedBF = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CbBackForward
            // 
            this.CbBackForward.FormattingEnabled = true;
            this.CbBackForward.Items.AddRange(new object[] {
            "Feedback",
            "Feedforward"});
            this.CbBackForward.Location = new System.Drawing.Point(181, 40);
            this.CbBackForward.Name = "CbBackForward";
            this.CbBackForward.Size = new System.Drawing.Size(121, 24);
            this.CbBackForward.TabIndex = 0;
            // 
            // feedButton
            // 
            this.feedButton.Location = new System.Drawing.Point(275, 369);
            this.feedButton.Name = "feedButton";
            this.feedButton.Size = new System.Drawing.Size(166, 60);
            this.feedButton.TabIndex = 1;
            this.feedButton.Text = "Give feed";
            this.feedButton.UseVisualStyleBackColor = true;
            this.feedButton.Click += new System.EventHandler(this.feedButton_Click);
            // 
            // TbCommentaryFeedBF
            // 
            this.TbCommentaryFeedBF.Location = new System.Drawing.Point(181, 143);
            this.TbCommentaryFeedBF.Name = "TbCommentaryFeedBF";
            this.TbCommentaryFeedBF.Size = new System.Drawing.Size(473, 22);
            this.TbCommentaryFeedBF.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Feedback of Feedfoward";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Commentary";
            // 
            // CbTeacher
            // 
            this.CbTeacher.FormattingEnabled = true;
            this.CbTeacher.Items.AddRange(new object[] {
            "Feedback",
            "Feedforward"});
            this.CbTeacher.Location = new System.Drawing.Point(181, 90);
            this.CbTeacher.Name = "CbTeacher";
            this.CbTeacher.Size = new System.Drawing.Size(121, 24);
            this.CbTeacher.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Leraar";
            // 
            // DtpFeedBF
            // 
            this.DtpFeedBF.Location = new System.Drawing.Point(181, 199);
            this.DtpFeedBF.Name = "DtpFeedBF";
            this.DtpFeedBF.Size = new System.Drawing.Size(200, 22);
            this.DtpFeedBF.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Datum";
            // 
            // FeedBackForwardPop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(687, 453);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DtpFeedBF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbTeacher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbCommentaryFeedBF);
            this.Controls.Add(this.feedButton);
            this.Controls.Add(this.CbBackForward);
            this.Name = "FeedBackForwardPop";
            this.Text = "FeedBackFoward";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbBackForward;
        private System.Windows.Forms.Button feedButton;
        private System.Windows.Forms.TextBox TbCommentaryFeedBF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbTeacher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtpFeedBF;
        private System.Windows.Forms.Label label4;
    }
}