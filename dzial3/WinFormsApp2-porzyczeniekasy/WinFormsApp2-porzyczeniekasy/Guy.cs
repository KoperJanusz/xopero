using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2_porzyczeniekasy
{
    public class Guy
    {
        public Guy(string a,int b)
        {
            name = a;
            cash = b;
        }
        string name;
        public int cash;
        public int GiveCash(int iloscWysylanych)
        {
            
                cash -= iloscWysylanych;
                return iloscWysylanych;
            
        }
        public void ReceiveCash(int iloscOdebranych)
        {
            
                cash += iloscOdebranych;
            
        
        }
        public string setInfo()
        {
            
            return name + " " + cash + "\n";
        }
    }
}
