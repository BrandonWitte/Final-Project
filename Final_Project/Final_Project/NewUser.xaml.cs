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
    /// Interaction logic for NewUser.xaml
    /// </summary>
    public partial class NewUser : Window
    {
        public NewUser()
        {
            InitializeComponent();
            lstGender.Items.Add("Male");
            lstGender.Items.Add("Female");
        }

        private void BtnCreateAccount_Click(object sender, RoutedEventArgs e)
        {
            NewCustomer newCustomer = new NewCustomer();
            if(txtFirstName.Text != "" && int.TryParse(txtFirstName.Text, out int firstNameResult) == false)
            {
                newCustomer.FirstName = txtFirstName.Text;
                if(txtLastName.Text != "" && int.TryParse(txtLastName.Text, out int lastNameResult) == false)
                {
                    newCustomer.LastName = txtLastName.Text;
                    if(int.TryParse(txtAge.Text, out int ageNumberResult))
                    {
                        newCustomer.Age = Convert.ToInt32(txtAge.Text);
                        if(lstGender.SelectedItem != null)
                        {
                            newCustomer.Gender = lstGender.SelectedItem.ToString();
                            if(txtEmail.Text != "" && int.TryParse(txtEmail.Text, out int emailNameResult) == false)
                            {
                                newCustomer.EmailAddress = txtEmail.Text;
                            }
                            else
                            {
                                MessageBox.Show("Please enter an email address.");
                                txtEmail.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select a gender.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter a valid age.");
                        txtAge.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Enter a valid last name.");
                    txtLastName.Clear();
                }
            }
            else
            {
                MessageBox.Show("Enter a valid first name.");
                txtFirstName.Clear();
            }
            //Slot_Machine slot_Machine = new Slot_Machine();
            //slot_Machine.Show();
            //Close();
        }
    }
}
