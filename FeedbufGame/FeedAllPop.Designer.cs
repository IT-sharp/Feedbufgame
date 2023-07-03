namespace FeedbufGame
{
    partial class FeedAllPop
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Feedup = new System.Windows.Forms.TabPage();
            this.LbFeedup = new System.Windows.Forms.ListBox();
            this.Feedback = new System.Windows.Forms.TabPage();
            this.LbFeedback = new System.Windows.Forms.ListBox();
            this.Feedforward = new System.Windows.Forms.TabPage();
            this.LbFeedforward = new System.Windows.Forms.ListBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.Tasks = new System.Windows.Forms.TabPage();
            this.LbTasks = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.Feedup.SuspendLayout();
            this.Feedback.SuspendLayout();
            this.Feedforward.SuspendLayout();
            this.Tasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Feedup);
            this.tabControl1.Controls.Add(this.Feedback);
            this.tabControl1.Controls.Add(this.Feedforward);
            this.tabControl1.Controls.Add(this.Tasks);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1264, 539);
            this.tabControl1.TabIndex = 0;
            // 
            // Feedup
            // 
            this.Feedup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Feedup.Controls.Add(this.LbFeedup);
            this.Feedup.Location = new System.Drawing.Point(4, 22);
            this.Feedup.Name = "Feedup";
            this.Feedup.Padding = new System.Windows.Forms.Padding(3);
            this.Feedup.Size = new System.Drawing.Size(1256, 513);
            this.Feedup.TabIndex = 0;
            this.Feedup.Text = "Feedup";
            // 
            // LbFeedup
            // 
            this.LbFeedup.FormattingEnabled = true;
            this.LbFeedup.Location = new System.Drawing.Point(16, 8);
            this.LbFeedup.Name = "LbFeedup";
            this.LbFeedup.Size = new System.Drawing.Size(1221, 485);
            this.LbFeedup.TabIndex = 0;
            // 
            // Feedback
            // 
            this.Feedback.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Feedback.Controls.Add(this.LbFeedback);
            this.Feedback.Location = new System.Drawing.Point(4, 22);
            this.Feedback.Name = "Feedback";
            this.Feedback.Padding = new System.Windows.Forms.Padding(3);
            this.Feedback.Size = new System.Drawing.Size(1256, 513);
            this.Feedback.TabIndex = 1;
            this.Feedback.Text = "Feedback";
            // 
            // LbFeedback
            // 
            this.LbFeedback.FormattingEnabled = true;
            this.LbFeedback.Location = new System.Drawing.Point(8, 9);
            this.LbFeedback.Name = "LbFeedback";
            this.LbFeedback.Size = new System.Drawing.Size(1232, 485);
            this.LbFeedback.TabIndex = 0;
            // 
            // Feedforward
            // 
            this.Feedforward.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Feedforward.Controls.Add(this.LbFeedforward);
            this.Feedforward.Location = new System.Drawing.Point(4, 22);
            this.Feedforward.Name = "Feedforward";
            this.Feedforward.Padding = new System.Windows.Forms.Padding(3);
            this.Feedforward.Size = new System.Drawing.Size(1256, 513);
            this.Feedforward.TabIndex = 2;
            this.Feedforward.Text = "Feedforward";
            // 
            // LbFeedforward
            // 
            this.LbFeedforward.FormattingEnabled = true;
            this.LbFeedforward.Location = new System.Drawing.Point(18, 14);
            this.LbFeedforward.Name = "LbFeedforward";
            this.LbFeedforward.Size = new System.Drawing.Size(1217, 472);
            this.LbFeedforward.TabIndex = 0;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(1152, 545);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(100, 27);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "Sluiten";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Tasks
            // 
            this.Tasks.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Tasks.Controls.Add(this.LbTasks);
            this.Tasks.Location = new System.Drawing.Point(4, 22);
            this.Tasks.Name = "Tasks";
            this.Tasks.Padding = new System.Windows.Forms.Padding(3);
            this.Tasks.Size = new System.Drawing.Size(1256, 513);
            this.Tasks.TabIndex = 3;
            this.Tasks.Text = "Taken";
            // 
            // LbTasks
            // 
            this.LbTasks.FormattingEnabled = true;
            this.LbTasks.Location = new System.Drawing.Point(18, 14);
            this.LbTasks.Name = "LbTasks";
            this.LbTasks.Size = new System.Drawing.Size(1221, 485);
            this.LbTasks.TabIndex = 1;
            // 
            // FeedAllPop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1264, 584);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.tabControl1);
            this.Name = "FeedAllPop";
            this.Text = "FeedAll";
            this.tabControl1.ResumeLayout(false);
            this.Feedup.ResumeLayout(false);
            this.Feedback.ResumeLayout(false);
            this.Feedforward.ResumeLayout(false);
            this.Tasks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Feedup;
        private System.Windows.Forms.ListBox LbFeedup;
        private System.Windows.Forms.TabPage Feedback;
        private System.Windows.Forms.ListBox LbFeedback;
        private System.Windows.Forms.TabPage Feedforward;
        private System.Windows.Forms.ListBox LbFeedforward;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.TabPage Tasks;
        private System.Windows.Forms.ListBox LbTasks;
    }
}