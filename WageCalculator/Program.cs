using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many hours you work? :\t");
            int hours = int.Parse(Console.ReadLine());

            Console.Write("How much are you payed per hour? :\t");
            int wage = int.Parse(Console.ReadLine());

            float overpay = (float)((5 * wage * 1.5) + (40 * wage));
            float regpay = (hours * wage);

            if (hours > 40)
            {
                Console.WriteLine();
                Console.WriteLine(" You have worked " + (hours - 40) + " hours overtime.");
                Console.WriteLine();
                Console.WriteLine("\t Before Tax is $" + overpay + " dollars.");
                Console.WriteLine("\t Tax payed $" + (overpay * 0.18) + " dollars.");
                Console.WriteLine();
                Console.WriteLine("\t After Tax is $" + (overpay - (overpay * 0.18)) + " dollars.");
            }
            else if(hours <= 40)
            {
                Console.WriteLine();
                Console.WriteLine("\t Before Tax is $" + regpay + " dollars.");
                Console.WriteLine("\t Tax payed $" + (regpay * 0.18) + " dollars.");
                Console.WriteLine();
                Console.WriteLine("\t After Tax is $" + (regpay - (regpay * 0.18)) + " dollars.");
            }

            Console.ReadKey();
        }
    }
}
