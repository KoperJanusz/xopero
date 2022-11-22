
namespace wyscigPsow
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
            this.tor = new System.Windows.Forms.PictureBox();
            this.pies1 = new System.Windows.Forms.PictureBox();
            this.pies2 = new System.Windows.Forms.PictureBox();
            this.pies3 = new System.Windows.Forms.PictureBox();
            this.pies4 = new System.Windows.Forms.PictureBox();
            this.wielkoscBet = new System.Windows.Forms.NumericUpDown();
            this.bet = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.janekRadio = new System.Windows.Forms.RadioButton();
            this.bartekRadio = new System.Windows.Forms.RadioButton();
            this.arekRadio = new System.Windows.Forms.RadioButton();
            this.nrPsa = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pies1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pies2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pies3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pies4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wielkoscBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrPsa)).BeginInit();
            this.SuspendLayout();
            // 
            // tor
            // 
            this.tor.BackgroundImage = global::wyscigPsow.Properties.Resources.racetrack;
            this.tor.Location = new System.Drawing.Point(3, 12);
            this.tor.Name = "tor";
            this.tor.Size = new System.Drawing.Size(603, 197);
            this.tor.TabIndex = 0;
            this.tor.TabStop = false;
            // 
            // pies1
            // 
            this.pies1.Image = global::wyscigPsow.Properties.Resources.dog;
            this.pies1.Location = new System.Drawing.Point(8, 12);
            this.pies1.Name = "pies1";
            this.pies1.Size = new System.Drawing.Size(80, 29);
            this.pies1.TabIndex = 1;
            this.pies1.TabStop = false;
            // 
            // pies2
            // 
            this.pies2.Image = global::wyscigPsow.Properties.Resources.dog;
            this.pies2.Location = new System.Drawing.Point(8, 66);
            this.pies2.Name = "pies2";
            this.pies2.Size = new System.Drawing.Size(80, 29);
            this.pies2.TabIndex = 2;
            this.pies2.TabStop = false;
            // 
            // pies3
            // 
            this.pies3.Image = global::wyscigPsow.Properties.Resources.dog;
            this.pies3.Location = new System.Drawing.Point(8, 119);
            this.pies3.Name = "pies3";
            this.pies3.Size = new System.Drawing.Size(80, 29);
            this.pies3.TabIndex = 3;
            this.pies3.TabStop = false;
            // 
            // pies4
            // 
            this.pies4.Image = global::wyscigPsow.Properties.Resources.dog;
            this.pies4.Location = new System.Drawing.Point(8, 169);
            this.pies4.Name = "pies4";
            this.pies4.Size = new System.Drawing.Size(80, 29);
            this.pies4.TabIndex = 4;
            this.pies4.TabStop = false;
            // 
            // wielkoscBet
            // 
            this.wielkoscBet.Location = new System.Drawing.Point(94, 404);
            this.wielkoscBet.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.wielkoscBet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.wielkoscBet.Name = "wielkoscBet";
            this.wielkoscBet.Size = new System.Drawing.Size(120, 23);
            this.wielkoscBet.TabIndex = 8;
            this.wielkoscBet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // bet
            // 
            this.bet.Location = new System.Drawing.Point(13, 402);
            this.bet.Name = "bet";
            this.bet.Size = new System.Drawing.Size(75, 23);
            this.bet.TabIndex = 11;
            this.bet.Text = "Postaw";
            this.bet.UseVisualStyleBackColor = true;
            this.bet.Click += new System.EventHandler(this.bet_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(514, 406);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 12;
            this.start.Text = "START";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // janekRadio
            // 
            this.janekRadio.AutoSize = true;
            this.janekRadio.Checked = true;
            this.janekRadio.Location = new System.Drawing.Point(55, 260);
            this.janekRadio.Name = "janekRadio";
            this.janekRadio.Size = new System.Drawing.Size(97, 19);
            this.janekRadio.TabIndex = 13;
            this.janekRadio.TabStop = true;
            this.janekRadio.Text = "Janek ma 50zl";
            this.janekRadio.UseVisualStyleBackColor = true;
            // 
            // bartekRadio
            // 
            this.bartekRadio.AutoSize = true;
            this.bartekRadio.Location = new System.Drawing.Point(55, 285);
            this.bartekRadio.Name = "bartekRadio";
            this.bartekRadio.Size = new System.Drawing.Size(101, 19);
            this.bartekRadio.TabIndex = 14;
            this.bartekRadio.Text = "Bartek ma 75zl";
            this.bartekRadio.UseVisualStyleBackColor = true;
            // 
            // arekRadio
            // 
            this.arekRadio.AutoSize = true;
            this.arekRadio.Location = new System.Drawing.Point(55, 310);
            this.arekRadio.Name = "arekRadio";
            this.arekRadio.Size = new System.Drawing.Size(92, 19);
            this.arekRadio.TabIndex = 15;
            this.arekRadio.Text = "Arek ma 45zl";
            this.arekRadio.UseVisualStyleBackColor = true;
            // 
            // nrPsa
            // 
            this.nrPsa.Location = new System.Drawing.Point(290, 404);
            this.nrPsa.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nrPsa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrPsa.Name = "nrPsa";
            this.nrPsa.Size = new System.Drawing.Size(120, 23);
            this.nrPsa.TabIndex = 20;
            this.nrPsa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "na psa nr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Janek nic nie postawil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Bartek nic nie postawil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Arek nic nie postawil";
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 474);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nrPsa);
            this.Controls.Add(this.arekRadio);
            this.Controls.Add(this.bartekRadio);
            this.Controls.Add(this.janekRadio);
            this.Controls.Add(this.start);
            this.Controls.Add(this.bet);
            this.Controls.Add(this.wielkoscBet);
            this.Controls.Add(this.pies4);
            this.Controls.Add(this.pies3);
            this.Controls.Add(this.pies2);
            this.Controls.Add(this.pies1);
            this.Controls.Add(this.tor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pies1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pies2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pies3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pies4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wielkoscBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrPsa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tor;
        private System.Windows.Forms.PictureBox pies1;
        private System.Windows.Forms.PictureBox pies2;
        private System.Windows.Forms.PictureBox pies3;
        private System.Windows.Forms.PictureBox pies4;
        private System.Windows.Forms.NumericUpDown wielkoscBet;
        private System.Windows.Forms.Button bet;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.RadioButton janekRadio;
        private System.Windows.Forms.RadioButton bartekRadio;
        private System.Windows.Forms.RadioButton arekRadio;
        private System.Windows.Forms.NumericUpDown nrPsa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}

