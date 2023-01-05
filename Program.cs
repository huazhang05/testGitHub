using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BankCharges
{
    internal class Program
    {
        static double accountBalance;
        static int numberOfCheck;

        static void Main(string[] args)//controler
        {
            inputView();
            serviceFee();
            outputView(serviceFee());

        }
        private static void inputView() //it will take input from the console
        {
            Console.WriteLine("Please input your balance of Account");
            accountBalance = (double)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many checks did you write?");
            int.TryParse(Console.ReadLine(), out numberOfCheck);

        }

        private static void outputView(double serviceFee)//show the reslut console,serviceFee is local variable for outputView
        {
            Console.WriteLine("Your bank's service fees for the month is " + serviceFee);
            Console.ReadKey();
        }
        private static double serviceFee()
        {
            if (accountBalance < 400)
                return 25;
            else
            {
                if (numberOfCheck < 20)
                    return 10 + 0.1 * numberOfCheck;
                else if (numberOfCheck >= 20 && numberOfCheck < 39)
                    return 10 + 0.08 * numberOfCheck;
                else if (numberOfCheck >= 20 && numberOfCheck < 39)
                    return 10 + 0.06 * numberOfCheck;
                else if (numberOfCheck >= 40 && numberOfCheck < 59)
                    return 10 + 0.08 * numberOfCheck;
                else
                    return 10 + 0.08 * numberOfCheck;
            }
        }
    }
}
