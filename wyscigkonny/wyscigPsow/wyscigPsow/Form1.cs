using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wyscigPsow
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
            

        }
        Greyhound[] pies = new Greyhound[4];
        Guy[] Guys = new Guy[3];

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            pies[0] = new Greyhound(pies1, pies1.Left, tor.Width - pies1.Width);
            pies[1] = new Greyhound(pies2, pies2.Left, tor.Width - pies2.Width);
            pies[2] = new Greyhound(pies3, pies3.Left, tor.Width - pies3.Width);
            pies[3] = new Greyhound(pies4, pies4.Left, tor.Width - pies4.Width);
            Guys[0] = new Guy()
            {
                Name = "Janek",
                Cash = 50,
                MyRadioButton = janekRadio,
                MyLabel = label2
            };
            Guys[1] = new Guy()
            {
                Name = "Bartek",
                Cash = 75,
                MyRadioButton = bartekRadio,
                MyLabel = label3
            };
            Guys[2] = new Guy()
            {
                Name = "Arek",
                Cash = 45,
                MyRadioButton = arekRadio,
                MyLabel = label4
            };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0;i<4; i ++)
            {
                if (pies[i].Location >= tor.Width-pies1.Width)
                {
                    timer1.Stop();
                    MessageBox.Show("wygral" + pies[i]);
                    break;                 
                }
                else
                {
                    pies[i].Run();
                }
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <4; i++)
            {
                pies[i].TakeStartingPosition();
            }
        }
    }        

}
