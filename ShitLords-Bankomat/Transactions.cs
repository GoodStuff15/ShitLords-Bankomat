using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shitlords_Bankomat
{
    internal class Transaction
    {
        private decimal _amount;
        private int _fromAccount;
        private int _toAccount;

        public decimal Amount { get; set; }
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }


        public Transaction(decimal amount, int fromAccount, int toAccount)
        {
            Amount = amount;
            FromAccount = fromAccount;
            ToAccount = toAccount;
            //Date.Time
        }
    }
}
