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

            if(Convert.ToInt32(txtCredits.Text) >= Convert.ToInt32(txtBet.Text))
            {
                txtCredits.Text = Convert.ToString((Decimal.Parse(txtCredits.Text)) - (Decimal.Parse(txtBet.Text)));
                if (num1 == num2 && num2 == num3)
                {
                    if(num1 == 1)
                    {
                        txtCredits.Text = Convert.ToString((Decimal.Parse(txtCredits.Text)) + 15);
                        MessageBox.Show("You won 15 credits!");
                    }
                    else if(num1 == 2)
                    {
                        txtCredits.Text = Convert.ToString((Decimal.Parse(txtCredits.Text)) + 25);
                        MessageBox.Show("You won 25 credits!");
                    }
                    else
                    {
                        txtCredits.Text = Convert.ToString((Decimal.Parse(txtCredits.Text)) + 50);
                        MessageBox.Show("You won 50 credits!");
                    }
                }
                if(num1 == num2 || num2 == num3 || num1 == num3)
                {
                    txtCredits.Text = Convert.ToString((Decimal.Parse(txtCredits.Text)) + 5);
                    MessageBox.Show("You won 5 credits!");
                }
                if (num1 != num2 && num2 != num3 && num1 != num3)
                {
                    txtCredits.Text = Convert.ToString((Decimal.Parse(txtCredits.Text)) + 0);
                    MessageBox.Show("You won 0 credits!");
                }
            }
            else
            {
                MessageBox.Show("Get out of my casino you have no more money!");
                Close();
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
