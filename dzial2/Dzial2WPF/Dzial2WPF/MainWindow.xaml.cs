using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dzial2WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            String name = "Quentin";
            int x = 3;
            x *= 17;
            double d = Math.PI / 2;
            myLabel.Text = "nazwa to " + name + "\nx jest rowne " + x + "\nd jest rowne " + d;
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int x = 15;
            if (x == 10)
                myLabel.Text = "x jest rowne 10";
            else
                myLabel.Text = "x jest rowne" + x;
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int someValue = 4;
            String name = "Krzysiek";
            if ((someValue == 3) && (name.Equals("Janek")))
            {
                myLabel.Text = "someValue jest rowne 3 i name rowne Janek";

            }
            myLabel.Text = "ten wiersz jest wykonywany bez wzgledu na warunki";
        }
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            while (count < 10)
            {
                count += 1;
            }
            for (int i = 0; i < 5; i++) {
                count += 1;
            }
            myLabel.Text = "Odpowiedz brzmi " + count;
        }
    }
}
