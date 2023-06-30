namespace FeedbufGame
{
    partial class AnimalSelectPop
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
            this.Frogbtn = new System.Windows.Forms.Button();
            this.DragonBtn = new System.Windows.Forms.Button();
            this.FoxBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose your animal !!!";
            // 
            // Frogbtn
            // 
            this.Frogbtn.Location = new System.Drawing.Point(56, 107);
            this.Frogbtn.Name = "Frogbtn";
            this.Frogbtn.Size = new System.Drawing.Size(98, 43);
            this.Frogbtn.TabIndex = 1;
            this.Frogbtn.Text = "Kikker";
            this.Frogbtn.UseVisualStyleBackColor = true;
            this.Frogbtn.Click += new System.EventHandler(this.Frogbtn_Click);
            // 
            // DragonBtn
            // 
            this.DragonBtn.Location = new System.Drawing.Point(229, 107);
            this.DragonBtn.Name = "DragonBtn";
            this.DragonBtn.Size = new System.Drawing.Size(98, 43);
            this.DragonBtn.TabIndex = 2;
            this.DragonBtn.Text = "Draak";
            this.DragonBtn.UseVisualStyleBackColor = true;
            this.DragonBtn.Click += new System.EventHandler(this.DragonBtn_Click);
            // 
            // FoxBtn
            // 
            this.FoxBtn.Location = new System.Drawing.Point(384, 107);
            this.FoxBtn.Name = "FoxBtn";
            this.FoxBtn.Size = new System.Drawing.Size(98, 43);
            this.FoxBtn.TabIndex = 3;
            this.FoxBtn.Text = "Vos";
            this.FoxBtn.UseVisualStyleBackColor = true;
            this.FoxBtn.Click += new System.EventHandler(this.FoxBtn_Click);
            // 
            // AnimalSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(568, 188);
            this.Controls.Add(this.FoxBtn);
            this.Controls.Add(this.DragonBtn);
            this.Controls.Add(this.Frogbtn);
            this.Controls.Add(this.label1);
            this.Name = "AnimalSelect";
            this.Text = "AnimalSelect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Frogbtn;
        private System.Windows.Forms.Button DragonBtn;
        private System.Windows.Forms.Button FoxBtn;
    }
}