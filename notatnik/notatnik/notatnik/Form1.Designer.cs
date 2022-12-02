
namespace notatnik
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
            this.components = new System.ComponentModel.Container();
            this.saveFile = new System.Windows.Forms.Button();
            this.ctrlF = new System.Windows.Forms.Button();
            this.ctrlH = new System.Windows.Forms.Button();
            this.textPliku = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nieBtn = new System.Windows.Forms.Button();
            this.takBtn = new System.Windows.Forms.Button();
            this.ctrlFtext = new System.Windows.Forms.TextBox();
            this.ctrlHtext = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(360, 2);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(75, 23);
            this.saveFile.TabIndex = 1;
            this.saveFile.Text = "Zapisz plik";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // ctrlF
            // 
            this.ctrlF.Location = new System.Drawing.Point(606, 2);
            this.ctrlF.Name = "ctrlF";
            this.ctrlF.Size = new System.Drawing.Size(75, 23);
            this.ctrlF.TabIndex = 2;
            this.ctrlF.Text = "ctrlF";
            this.ctrlF.UseVisualStyleBackColor = true;
            this.ctrlF.Click += new System.EventHandler(this.ctrlF_Click);
            // 
            // ctrlH
            // 
            this.ctrlH.Location = new System.Drawing.Point(713, 2);
            this.ctrlH.Name = "ctrlH";
            this.ctrlH.Size = new System.Drawing.Size(75, 23);
            this.ctrlH.TabIndex = 3;
            this.ctrlH.Text = "ctrlH";
            this.ctrlH.UseVisualStyleBackColor = true;
            this.ctrlH.Click += new System.EventHandler(this.ctrlH_Click);
            // 
            // textPliku
            // 
            this.textPliku.HideSelection = false;
            this.textPliku.Location = new System.Drawing.Point(12, 80);
            this.textPliku.Multiline = true;
            this.textPliku.Name = "textPliku";
            this.textPliku.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textPliku.Size = new System.Drawing.Size(776, 358);
            this.textPliku.TabIndex = 4;
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(31, 2);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(75, 23);
            this.openFile.TabIndex = 0;
            this.openFile.Text = "Otworz plik";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.nieBtn);
            this.groupBox1.Controls.Add(this.takBtn);
            this.groupBox1.Location = new System.Drawing.Point(295, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 53);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Plik ktory chcesz otworzyc wazy wiecej  niz 50MB czy napewno chcesz go otworzyc?";
            // 
            // nieBtn
            // 
            this.nieBtn.Location = new System.Drawing.Point(119, 71);
            this.nieBtn.Name = "nieBtn";
            this.nieBtn.Size = new System.Drawing.Size(75, 23);
            this.nieBtn.TabIndex = 1;
            this.nieBtn.Text = "Nie";
            this.nieBtn.UseVisualStyleBackColor = true;
            this.nieBtn.Click += new System.EventHandler(this.nieBtn_Click);
            // 
            // takBtn
            // 
            this.takBtn.Location = new System.Drawing.Point(6, 71);
            this.takBtn.Name = "takBtn";
            this.takBtn.Size = new System.Drawing.Size(75, 23);
            this.takBtn.TabIndex = 0;
            this.takBtn.Text = "tak";
            this.takBtn.UseVisualStyleBackColor = true;
            this.takBtn.Click += new System.EventHandler(this.takBtn_Click);
            // 
            // ctrlFtext
            // 
            this.ctrlFtext.Location = new System.Drawing.Point(593, 31);
            this.ctrlFtext.Multiline = true;
            this.ctrlFtext.Name = "ctrlFtext";
            this.ctrlFtext.Size = new System.Drawing.Size(100, 43);
            this.ctrlFtext.TabIndex = 7;
            // 
            // ctrlHtext
            // 
            this.ctrlHtext.Location = new System.Drawing.Point(699, 31);
            this.ctrlHtext.Multiline = true;
            this.ctrlHtext.Name = "ctrlHtext";
            this.ctrlHtext.Size = new System.Drawing.Size(100, 43);
            this.ctrlHtext.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(797, 436);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 236);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "wait...";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ctrlHtext);
            this.Controls.Add(this.ctrlFtext);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textPliku);
            this.Controls.Add(this.ctrlH);
            this.Controls.Add(this.ctrlF);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.openFile);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.Button ctrlF;
        private System.Windows.Forms.Button ctrlH;
        private System.Windows.Forms.TextBox textPliku;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button nieBtn;
        private System.Windows.Forms.Button takBtn;
        private System.Windows.Forms.TextBox ctrlFtext;
        private System.Windows.Forms.TextBox ctrlHtext;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

