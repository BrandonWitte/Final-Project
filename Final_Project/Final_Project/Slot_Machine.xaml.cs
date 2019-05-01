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
using System.Windows.Shapes;

namespace Final_Project
{
    /// <summary>
    /// Interaction logic for Slot_Machine.xaml
    /// </summary>
    public partial class Slot_Machine : Window
    {
        public string different { get; set; }
        public Slot_Machine()
        {
            InitializeComponent();
        }

        private void BtnSpin_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int num1 = rnd.Next(1, 4);
            int num2 = rnd.Next(1, 4);
            int num3 = rnd.Next(1, 4);
            txtnum1.Text = num1.ToString();
            txtnum2.Text = num2.ToString();
            txtnum3.Text = num3.ToString();
            
            if (num1 == num2 && num2 == num3)
            {
                txtCredits.Text = Convert.ToString((Decimal.Parse(txtCredits.Text)) + 10);
            }
        }

        private void BtnLogOut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtSlotName.Text = different;
        }
    }
}
