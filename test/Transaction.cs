using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Transaction
    {
        public double Amount;
        public double MobileNumber;
        public double ReceiverNumber;
            public Transaction(double a,double b,double c)
        {
            Amount = a;MobileNumber = b;ReceiverNumber = c;
        }
        public Transaction() { }
    }
}
