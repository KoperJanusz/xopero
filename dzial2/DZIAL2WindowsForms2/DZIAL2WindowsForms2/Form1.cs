using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZIAL2WindowsForms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            int z = 1;
            while(Visible){
                for (int i = 0; i < 254; i++)
                {

                    this.BackColor = Color.FromArgb(i, 255 - i, i);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);
                }



                for (int b = 254; b > 0; b--)
                {

                    this.BackColor = Color.FromArgb(b, 255 - b, b);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);
                }
            }

        }
    }
}
