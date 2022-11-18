using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DZIAL2Formsapp1
{
    class AnotherClass
    {
        public static void Main()
        {
            MessageBox.Show("bum!");
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
