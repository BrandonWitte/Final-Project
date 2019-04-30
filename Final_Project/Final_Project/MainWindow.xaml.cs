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

namespace Final_Project
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

        private void BtnSignUp_Click(object sender, RoutedEventArgs e)
        {
            NewUser newUser = new NewUser();
            newUser.Show();
            Close();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if(txtUserName.Text == "username")
            {
                if(txtPassword.Text == "password")
                {
                    Slot_Machine slot_Machine = new Slot_Machine();
                    slot_Machine.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Enter a valid password.");
                    txtPassword.Clear();
                }
            }
            else
            {
                MessageBox.Show("Enter a valid username.");
                txtUserName.Clear();
            }
        }

        private void Btnbanktest_Click(object sender, RoutedEventArgs e)
        {
            Banking banking = new Banking();
            banking.Show();
            Close();
        }
    }
}
