using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
        void saveAFile()
        {
           

            if (!File.Exists(path))
            {
                MessageBox.Show("Plik nie istnieje");
            }
            else
            {
                
                startText = startText.Replace(startText, textPliku.Text);
                File.WriteAllText(path,startText);


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
            saveAFile();
        }

        private void takBtn_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            
            
            openAFile();
            MessageBox.Show("otwarto plik");

        }

        private void nieBtn_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            MessageBox.Show("Nie zgodziles sie na otwarcie pliku");

        }

        private void ctrlF_Click(object sender, EventArgs e)
        {
            bool containsSearchResult = textBox1.Text.Contains(ctrlFtext.Text);
            

            if (containsSearchResult==true)
            {
                MessageBox.Show("znalazlo sie");
            }
            else
            {
                MessageBox.Show("nie znalazlo sie");

            }
        }
    }
}
