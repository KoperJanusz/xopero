using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notatnik
{
    
    public partial class Form1 : Form
    {
        string path;
        string startText;


        public Form1()
        {
            InitializeComponent();
            


        }
        void openAFile()
        {
            
            
            if (!File.Exists(path))
            {
                MessageBox.Show("Plik nie istnieje");
            }
            else 
            {
                textPliku.Text= File.ReadAllText(path);
                startText= textPliku.Text;


            }
        }

     
        public void getPath()
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Access files (*.txt)|";

            
            var ofd = openFileDialog1;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if(new FileInfo(ofd.FileName).Length > 5)
                {
                   
                    groupBox1.Visible = true;
                    

                }
                else
                {                   
                   openAFile();
                }

            }

            path = @openFileDialog1.FileName;



        }


        


        private void openFile_Click(object sender, EventArgs e)
        {
            getPath();
            
            
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            {
                MessageBox.Show("Plik nie istnieje");
            }
            else
            {
                startText = startText.Replace(startText, textPliku.Text);
                File.WriteAllText(path, startText);


            }
        }

        private void takBtn_Click(object sender, EventArgs e)
        {

            groupBox1.Visible = false;
            groupBox2.Visible = true;
            timer1.Start();
            
            openAFile();




        }

        private void nieBtn_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;

        }

        private void ctrlF_Click(object sender, EventArgs e)
        {
                for (int x = 0; x < textPliku.Lines.Count(); x++)
                {

                    if (textPliku.Lines[x].ToLower().Contains (ctrlFtext.Text.ToLower()) && ctrlFtext.Text!="")
                    {
                        MessageBox.Show("znaleziony tekst znajduje sie w linicje: "+(x+1));
                    }
                }           
        }

        public void ponumeruj()
        {
            richtextbox.Text = "";
            for (int i = 1; i <= textPliku.Lines.Count(); i++) {
                richtextbox.Text += "" + i + "\r\n";
            }
        }


        private void ctrlH_Click(object sender, EventArgs e)
        {
            if (ctrlFtext.Text != "" && ctrlHtext.Text.Length  >0 && textPliku.Text.Contains(ctrlFtext.Text) == true)
            {
                textPliku.Text = textPliku.Text.Replace(ctrlFtext.Text, ctrlHtext.Text);
            }
            else
            {
                MessageBox.Show("nie znaleziono frazy ktorej szukasz");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 2;
            if (progressBar1.Value >= 100)
            {
                timer1.Stop();
                groupBox2.Visible = false;                            
            }           
        }

        public enum ScrollBarType : uint
        {
            SbHorz = 0,
            SbVert = 1,
            SbCtl = 2,
            SbBoth = 3
        }

        public enum Message : uint
        {
            WM_VSCROLL = 0x0115
        }

        public enum ScrollBarCommands : uint
        {
            SB_THUMBPOSITION = 4
        }
        [DllImport("User32.dll")]
        public extern static int GetScrollPos(IntPtr hWnd, int nBar);

        [DllImport("User32.dll")]
        public extern static int SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);
        private void textPliku_VScroll(object sender, EventArgs e)
        {
            int nPos = GetScrollPos(textPliku.Handle, (int)ScrollBarType.SbVert);
            nPos <<= 16;
            uint wParam = (uint)ScrollBarCommands.SB_THUMBPOSITION | (uint)nPos;
            SendMessage(richtextbox.Handle, (int)Message.WM_VSCROLL, new IntPtr(wParam), new IntPtr(0));
        }

        private void textPliku_TextChanged(object sender, EventArgs e)
        {
            ponumeruj();
        }
    }
}
 