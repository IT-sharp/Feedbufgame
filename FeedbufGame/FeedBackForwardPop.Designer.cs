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
            this.TbComFeed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbTeacher = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbGoal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CbBackForward
            // 
            this.CbBackForward.FormattingEnabled = true;
            this.CbBackForward.Items.AddRange(new object[] {
            "Feedback",
            "Feedforward"});
            this.CbBackForward.Location = new System.Drawing.Point(136, 32);
            this.CbBackForward.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbBackForward.Name = "CbBackForward";
            this.CbBackForward.Size = new System.Drawing.Size(125, 21);
            this.CbBackForward.TabIndex = 0;
            this.CbBackForward.Text = "Feedback";
            // 
            // feedButton
            // 
            this.feedButton.Location = new System.Drawing.Point(194, 226);
            this.feedButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.feedButton.Name = "feedButton";
            this.feedButton.Size = new System.Drawing.Size(124, 49);
            this.feedButton.TabIndex = 1;
            this.feedButton.Text = "Give feed";
            this.feedButton.UseVisualStyleBackColor = true;
            this.feedButton.Click += new System.EventHandler(this.feedButton_Click);
            // 
            // TbComFeed
            // 
            this.TbComFeed.Location = new System.Drawing.Point(136, 156);
            this.TbComFeed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbComFeed.Name = "TbComFeed";
            this.TbComFeed.Size = new System.Drawing.Size(356, 20);
            this.TbComFeed.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Feedback of Feedfoward";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Commentary";
            // 
            // CbTeacher
            // 
            this.CbTeacher.FormattingEnabled = true;
            this.CbTeacher.Items.AddRange(new object[] {
            "Feedback",
            "Feedforward"});
            this.CbTeacher.Location = new System.Drawing.Point(136, 113);
            this.CbTeacher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbTeacher.Name = "CbTeacher";
            this.CbTeacher.Size = new System.Drawing.Size(125, 21);
            this.CbTeacher.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Leraar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Leerdoel";
            // 
            // CbGoal
            // 
            this.CbGoal.FormattingEnabled = true;
            this.CbGoal.Items.AddRange(new object[] {
            "Feedback",
            "Feedforward"});
            this.CbGoal.Location = new System.Drawing.Point(136, 72);
            this.CbGoal.Margin = new System.Windows.Forms.Padding(2);
            this.CbGoal.Name = "CbGoal";
            this.CbGoal.Size = new System.Drawing.Size(125, 21);
            this.CbGoal.TabIndex = 8;
            // 
            // FeedBackForwardPop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(515, 368);
            this.Controls.Add(this.CbGoal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbTeacher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbComFeed);
            this.Controls.Add(this.feedButton);
            this.Controls.Add(this.CbBackForward);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FeedBackForwardPop";
            this.Text = "FeedBackFoward";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbBackForward;
        private System.Windows.Forms.Button feedButton;
        private System.Windows.Forms.TextBox TbComFeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbTeacher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbGoal;
    }
}