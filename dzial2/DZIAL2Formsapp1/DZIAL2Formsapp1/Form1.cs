using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZIAL2Formsapp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void changeText_Click(object sender, EventArgs e)
        {
            if (enableCheckbox.Checked == true) {
            if(labelToChange.Text=="Z Prawej")
                {
                    labelToChange.Text = "Z lewej";
                    labelToChange.TextAlign = ContentAlignment.MiddleLeft;
                }
                else
                {
                    labelToChange.Text = "Z Prawej";
                    labelToChange.TextAlign = ContentAlignment.MiddleRight;
                }
            }
            else
            {
                labelToChange.Text = "Mozliwosc zmiany zostala wylaczona";
                labelToChange.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void enableCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            changeText_Click(sender,e);
        }
    }
}
