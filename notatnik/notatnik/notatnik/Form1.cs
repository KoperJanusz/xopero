using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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


            if (textPliku.Text.ToLower().Contains(ctrlFtext.Text.ToLower())==true&& ctrlFtext.Text!="")
            {
                MessageBox.Show("znaleziono tekst");
                string v = ctrlFtext.Text.ToUpper();                         
                textPliku.Text = textPliku.Text.Replace(ctrlFtext.Text, v);
                
                for (int x = 1; x <= textPliku.Lines.Count(); x++)
                {

                    if (textPliku.Lines[x-1].ToLower() == ctrlFtext.Text.ToLower())
                    {
                        
                        
                        MessageBox.Show("znaleziony tekst znajduje sie w linicje: "+x);
                        textPliku.SelectionStart = x*3;
                        textPliku.SelectionLength = textPliku.Lines[x-1].Length;
                        textPliku.ScrollToCaret();
                        //  nie     nie mam pojecia czemu, nie wiem na jakiej zasadzie to dziala po prostu nieamsdmwwwchuj chuj chuj chj cucjhhasdad;;wasd ammsadammmmmsdkadoasdw
                    }
                }
                
                

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
    }
}
//w timerze sprawdzam dlugosc pliku i na nim daje maxa, i przeskakuje potem o 5% jego maxa