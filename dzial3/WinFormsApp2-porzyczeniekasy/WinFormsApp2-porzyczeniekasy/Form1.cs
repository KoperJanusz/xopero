using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2_porzyczeniekasy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        Guy joe = new Guy("Joe", 100);
        Guy bob = new Guy("Bob", 100);
        private void setInformation()
        {
            information.Text = null;
            information.Text += joe.setInfo();
            information.Text += bob.setInfo();


        }
        
        

        private void send_Click(object sender, EventArgs e)
        {
            
            if ((int)numericJoe.Value <= joe.cash)
            {
                joe.GiveCash((int)numericJoe.Value);
                bob.ReceiveCash((int)numericJoe.Value);
            }
            else
            {
                MessageBox.Show("Joe nie ma wystarczajacej ilosci pieniedzy!");
            }
            setInformation();
        }

        private void send2_Click(object sender, EventArgs e)
        {
            if ((int)numericBob.Value <= bob.cash)
            {
                bob.GiveCash((int)numericBob.Value);
                joe.ReceiveCash((int)numericBob.Value);
            }
            else
            {
                MessageBox.Show("Bob nie ma wystarczajacej ilosci pieniedzy!");
            }
            setInformation();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setInformation();
        }

       
    }
}
