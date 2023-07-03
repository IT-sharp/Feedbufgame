namespace FeedbufGame
{
    partial class TaskPop
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbTask = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbGoal = new System.Windows.Forms.ComboBox();
            this.AddTaskBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opdrachten die uitgevoerd moeten worden om het leerdoel te behalen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Voer je taak in";
            // 
            // TbTask
            // 
            this.TbTask.Location = new System.Drawing.Point(15, 56);
            this.TbTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbTask.Name = "TbTask";
            this.TbTask.Size = new System.Drawing.Size(493, 20);
            this.TbTask.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Koppel de taak aan het leerdoel";
            // 
            // CbGoal
            // 
            this.CbGoal.FormattingEnabled = true;
            this.CbGoal.Location = new System.Drawing.Point(13, 110);
            this.CbGoal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbGoal.Name = "CbGoal";
            this.CbGoal.Size = new System.Drawing.Size(235, 21);
            this.CbGoal.TabIndex = 5;
            // 
            // AddTaskBtn
            // 
            this.AddTaskBtn.Location = new System.Drawing.Point(172, 196);
            this.AddTaskBtn.Name = "AddTaskBtn";
            this.AddTaskBtn.Size = new System.Drawing.Size(153, 85);
            this.AddTaskBtn.TabIndex = 6;
            this.AddTaskBtn.Text = "Voeg taak toe";
            this.AddTaskBtn.UseVisualStyleBackColor = true;
            this.AddTaskBtn.Click += new System.EventHandler(this.AddTaskBtn_Click);
            // 
            // TaskPop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.AddTaskBtn);
            this.Controls.Add(this.CbGoal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbTask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TaskPop";
            this.Text = "Tasks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbGoal;
        private System.Windows.Forms.Button AddTaskBtn;
    }
}