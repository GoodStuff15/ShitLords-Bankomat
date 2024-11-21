using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shitlords_Bankomat
{
    public abstract class Account
    {
        public List<History> history;
        private string _accountName;
        private decimal _amount;
        private decimal _currency;
        private int _accountNumber;
        private int _ownerID;


        public Account(string accountName, decimal amount, decimal currency, int accountNumber, int ownerID)
        {
            history = new List<History>();
            _accountName = accountName;
            _amount = amount;
            _currency = currency;
            _accountNumber = accountNumber;
            _ownerID = ownerID;
        }


    }
}
