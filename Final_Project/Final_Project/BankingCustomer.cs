using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class BankingCustomer
    {
        public string CardType { get; set; }
        public string CustomerName { get; set; }
        public long CardNumber { get; set; }
        public int SecurityCode { get; set; }

        public BankingCustomer()
        {
            CardType = "";
            CustomerName = "";
            CardNumber = 0;
            SecurityCode = 0;
        }

        public BankingCustomer(string cardType, string customerName, long cardNumber, int securityCode)
        {
            CardType = cardType;
            CustomerName = customerName;
            CardNumber = cardNumber;
            SecurityCode = securityCode;
        }
    }
}
