
namespace WinFormsApp2_porzyczeniekasy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericJoe = new System.Windows.Forms.NumericUpDown();
            this.numericBob = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Button();
            this.information = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericJoe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBob)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "joe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "bob";
            // 
            // numericJoe
            // 
            this.numericJoe.Location = new System.Drawing.Point(145, 38);
            this.numericJoe.Name = "numericJoe";
            this.numericJoe.Size = new System.Drawing.Size(120, 23);
            this.numericJoe.TabIndex = 4;
            // 
            // numericBob
            // 
            this.numericBob.Location = new System.Drawing.Point(567, 38);
            this.numericBob.Name = "numericBob";
            this.numericBob.Size = new System.Drawing.Size(120, 23);
            this.numericBob.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "<-ile dac->";
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(385, 102);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 8;
            this.send.Text = "wysij";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // information
            // 
            this.information.AutoSize = true;
            this.information.Location = new System.Drawing.Point(385, 292);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(0, 15);
            this.information.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.information);
            this.Controls.Add(this.send);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericBob);
            this.Controls.Add(this.numericJoe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericJoe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericJoe;
        private System.Windows.Forms.NumericUpDown numericBob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Label information;
    }
}

