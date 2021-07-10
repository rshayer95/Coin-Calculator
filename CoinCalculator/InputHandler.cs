using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCalculator
{
    class InputHandler
    {
        public static string five_cents;
        public static string ten_cents;
        public static string twentyfive_cents;
        public static string fifty_cents;
        public static string one_dollar;
        public static string two_dollar;
        public void questions()
        {
            Console.WriteLine("please enter the amount of coin of 5 cents");
            five_cents = Console.ReadLine();
            Console.WriteLine("please enter the amount of coin of 10 cents");
            ten_cents = Console.ReadLine();
            Console.WriteLine("please enter the amount of coin of 25 cents");
            twentyfive_cents = Console.ReadLine();
            Console.WriteLine("please enter the amount of coin of 50 cents");
            fifty_cents = Console.ReadLine();
            Console.WriteLine("please enter the amount of coin of 1 dollar");
            one_dollar = Console.ReadLine();
            Console.WriteLine("please enter the amount of coin of 2 dollar");
            two_dollar = Console.ReadLine();
        }
    }
}
