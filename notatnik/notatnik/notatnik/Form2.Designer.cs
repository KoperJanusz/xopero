
namespace notatnik
{
    partial class Form2
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
            this.takBtn = new System.Windows.Forms.Button();
            this.nieBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // takBtn
            // 
            this.takBtn.Location = new System.Drawing.Point(12, 95);
            this.takBtn.Name = "takBtn";
            this.takBtn.Size = new System.Drawing.Size(75, 23);
            this.takBtn.TabIndex = 0;
            this.takBtn.Text = "tak";
            this.takBtn.UseVisualStyleBackColor = true;
            this.takBtn.Click += new System.EventHandler(this.takBtn_Click);
            // 
            // nieBtn
            // 
            this.nieBtn.Location = new System.Drawing.Point(100, 95);
            this.nieBtn.Name = "nieBtn";
            this.nieBtn.Size = new System.Drawing.Size(75, 23);
            this.nieBtn.TabIndex = 1;
            this.nieBtn.Text = "nie";
            this.nieBtn.UseVisualStyleBackColor = true;
            this.nieBtn.Click += new System.EventHandler(this.nieBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 77);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Plik ktory chcesz otworzyc wazy wiecej  niz 50MB czy napewno chcesz go otworzyc?";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 130);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nieBtn);
            this.Controls.Add(this.takBtn);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button takBtn;
        private System.Windows.Forms.Button nieBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}