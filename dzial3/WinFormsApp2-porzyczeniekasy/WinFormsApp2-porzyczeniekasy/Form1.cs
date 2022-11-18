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
        public void setInformation()
        {
            information.Text = null;
            information.Text += joe.setInfo();
            information.Text += bob.setInfo();


        }

        

        private void send_Click(object sender, EventArgs e)
        {
            bob.GiveCash((int)numericBob.Value);
            joe.ReceiveCash((int)numericBob.Value);
            
            joe.GiveCash((int)numericJoe.Value);
            bob.ReceiveCash((int)numericJoe.Value);
            setInformation();
        }

        
    }
}
