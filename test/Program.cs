
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cin username and password");
            string username = Console.ReadLine();
            string pass = Console.ReadLine();
            Authorization a = new Authorization(username, pass);

            Operation w=new Operation();
            if (w.Verify(a)) {
                Console.WriteLine("cin amount");
                string amount1=Console.ReadLine();
                double amount = Convert.ToDouble(amount1);
                Console.WriteLine("cin mobilenumber");
                string mobileNumber1 = Console.ReadLine();
                double mobileNumber = Convert.ToDouble(mobileNumber1);
                Console.WriteLine("cin receivenumber");
                string receiverNumber1 = Console.ReadLine();
                double receiverNumber = Convert.ToDouble(receiverNumber1);

                Transaction t = new Transaction(amount,mobileNumber,receiverNumber);
                double x=w.Pay(t);
                w.Print(t);

            }
            else { Console.WriteLine("wrong user or password"); }
            Console.ReadKey();
        }
    }
}
