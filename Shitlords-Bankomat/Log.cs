using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shitlords_Bankomat
{
    internal class Log
    {
        DateTime _timeStamp;
        private decimal _amount;
        private int _fromAccount;
        private int _toAccount;

        public DateTime TimeStamp { get; set; }
        public decimal Amount { get; set; }
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }

        public Log(decimal amount, int fromAccount, int toAccount)
        {
            TimeStamp = DateTime.Now;
            Amount = amount;
            FromAccount = fromAccount;
            ToAccount = toAccount;
        }
    }
}
