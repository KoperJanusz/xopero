using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace WinFormsApp1
{
    class Talker
    {
       
        public static int BlahBlahBlah(string thingstosay, int numberoftimes)
        {
            string finalstring = "";
            for(int i = numberoftimes; i > 0; i--)
            {
                finalstring += thingstosay;
            }
            MessageBox.Show(finalstring);
            return finalstring.Length;
        }
    }
}
