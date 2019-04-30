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
    /// Interaction logic for Banking.xaml
    /// </summary>
    public partial class Banking : Window
    {
        public Banking()
        {
            InitializeComponent();
            comboCardType.Items.Add("Master Card");
            comboCardType.Items.Add("American Express");
            comboCardType.Items.Add("Visa");
        }

        private void BtnUpdateBanking_Click(object sender, RoutedEventArgs e)
        {
            BankingCustomer bankingCustomer = new BankingCustomer();
            bankingCustomer.CardType = comboCardType.SelectedItem.ToString();
            if(comboCardType.SelectedItem.ToString() == "Master Card")
            {
                if (txtCardName.Text != "" && int.TryParse(txtCardName.Text, out int cardNameResult) == false)
                {
                    bankingCustomer.CustomerName = txtCardName.Text;
                    if (txtCardNumber.Text.ToString().Length == 16 && int.TryParse(txtCardNumber.Text, out int cardNumberResult))
                    {
                        bankingCustomer.CardNumber = Convert.ToInt32(txtCardNumber.Text);
                        if (txtSecurityCode.Text.ToString().Length == 3 && int.TryParse(txtSecurityCode.Text, out int securityCodeResult))
                        {
                            bankingCustomer.SecurityCode = Convert.ToInt32(txtSecurityCode.Text);
                            Slot_Machine slot_Machine = new Slot_Machine();
                            slot_Machine.Show();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid security code.");
                            txtSecurityCode.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid card number.");
                        txtCardNumber.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid cardholder name.");
                    txtCardName.Clear();
                }
            }
            else if (comboCardType.SelectedItem.ToString() == "American Express")
            {
                if (txtCardName.Text != "" && int.TryParse(txtCardName.Text, out int cardNameResult) == false)
                {
                    bankingCustomer.CustomerName = txtCardName.Text;
                    if (txtCardNumber.Text.ToString().Length == 15 && int.TryParse(txtCardNumber.Text, out int cardNumberResult))
                    {
                        bankingCustomer.CardNumber = Convert.ToInt32(txtCardNumber.Text);
                        if (txtSecurityCode.Text.ToString().Length == 4 && int.TryParse(txtSecurityCode.Text, out int securityCodeResult))
                        {
                            bankingCustomer.SecurityCode = Convert.ToInt32(txtSecurityCode.Text);
                            Slot_Machine slot_Machine = new Slot_Machine();
                            slot_Machine.Show();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid security code.");
                            txtSecurityCode.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid card number.");
                        txtCardNumber.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid cardholder name.");
                    txtCardName.Clear();
                }
            }
            else if (comboCardType.SelectedItem.ToString() == "Visa")
            {
                if (txtCardName.Text != "" && int.TryParse(txtCardName.Text, out int cardNameResult) == false)
                {
                    bankingCustomer.CustomerName = txtCardName.Text;
                    if (int.TryParse(txtCardNumber.Text, out int cardNumberResult))
                    {
                        bankingCustomer.CardNumber = Convert.ToInt32(txtCardNumber.Text);
                        if (txtSecurityCode.Text.ToString().Length == 3 && int.TryParse(txtSecurityCode.Text, out int securityCodeResult))
                        {
                            bankingCustomer.SecurityCode = Convert.ToInt32(txtSecurityCode.Text);
                            Slot_Machine slot_Machine = new Slot_Machine();
                            slot_Machine.Show();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid security code.");
                            txtSecurityCode.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid card number.");
                        txtCardNumber.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid cardholder name.");
                    txtCardName.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please select a card type.");
            }
        }
    }
}
