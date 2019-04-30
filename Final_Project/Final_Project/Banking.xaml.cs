﻿using System;
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
            Slot_Machine slot_Machine = new Slot_Machine();
            slot_Machine.Show();
            Close();
        }
    }
}
