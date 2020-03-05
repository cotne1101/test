using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Operation 
    {

        
        public bool Verify(Authorization a)
        {
            if (a.UserName == constants.username && a.Password==constants.password){ return true; }
             return false;
        }

        public double Pay(Transaction a)
        {
            return 10;

        }


        public void Print(Transaction a)
        {
            //თანხა, ნომერი, მიმღების ნომერი, იუზერის სახელი და გვარი
            Console.WriteLine();
            Console.Write("amount: ");
            Console.WriteLine(a.Amount);
            Console.Write("mobile number: ");
            Console.WriteLine(a.MobileNumber);
            Console.Write("reciever number: ");
            Console.WriteLine(a.ReceiverNumber);
            Console.Write("username: ");
            Console.WriteLine(constants.Name);
        }     
    }
}
