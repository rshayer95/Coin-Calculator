using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCalculator
{
    class Output
    {
        public double fiveCentsTotal;
        public double tenCentsTotal;
        public double twentyfiveCentsTotal;
        public double fiftyCentsTotal;
        public double oneDollarTotal;
        public double twoDollarTotal;
        public void output()
        {
            Console.WriteLine("Coins\t\tAmount\t\tTotal");
            //Print 5 Cent coin details
            Console.WriteLine("5 Cents\t\t"+ "x"+InputHandler.five_cents+"\t\t" + "$"+(double)0.005*Convert.ToInt32(InputHandler.five_cents));
            //Print 10 Cent coin details
            Console.WriteLine("10 Cents\t" + "x" + InputHandler.ten_cents + "\t\t" + "$" + (double)0.10 * Convert.ToInt32(InputHandler.ten_cents));
            //Print 25 Cent coin details
            Console.WriteLine("25 Cents\t" + "x" + InputHandler.twentyfive_cents + "\t\t" + "$" + (double)0.25 * Convert.ToInt32(InputHandler.twentyfive_cents));
            //Print 50 Cent coin details
            Console.WriteLine("50 Cents\t" + "x" + InputHandler.fifty_cents + "\t\t" + "$" + (double)0.50 * Convert.ToInt32(InputHandler.fifty_cents));
            //Print 1 dollar coin details
            Console.WriteLine("1 Dollar\t" + "x" + InputHandler.one_dollar + "\t\t" + "$" + (double)1 * Convert.ToInt32(InputHandler.one_dollar));
            //Print 2 dollar coin details
            Console.WriteLine("2 Dollar\t" + "x" + InputHandler.two_dollar + "\t\t" + "$" + (double)2 * Convert.ToInt32(InputHandler.two_dollar));

            double total = Convert.ToDouble(InputHandler.five_cents) + Convert.ToDouble(InputHandler.ten_cents) + Convert.ToDouble(InputHandler.twentyfive_cents) + Convert.ToDouble(InputHandler.fifty_cents) + Convert.ToDouble(InputHandler.one_dollar) + Convert.ToDouble(InputHandler.two_dollar);

            //Assign Totals
            fiveCentsTotal = (double)0.005 * Convert.ToInt32(InputHandler.five_cents);
            tenCentsTotal = (double)0.10 * Convert.ToInt32(InputHandler.ten_cents);
            twentyfiveCentsTotal = (double)0.25 * Convert.ToInt32(InputHandler.twentyfive_cents);
            fiftyCentsTotal = (double)0.50 * Convert.ToInt32(InputHandler.fifty_cents);
            oneDollarTotal = (double)1 * Convert.ToInt32(InputHandler.one_dollar);
            twoDollarTotal = (double)2 * Convert.ToInt32(InputHandler.two_dollar);

            //Calculate Fee
            double fee = (fiveCentsTotal + tenCentsTotal + twentyfiveCentsTotal + fiftyCentsTotal + oneDollarTotal + twoDollarTotal) * 0.15;

            //Total Fee
            double totalFee = fiveCentsTotal + tenCentsTotal + twentyfiveCentsTotal + fiftyCentsTotal + oneDollarTotal + twoDollarTotal + fee;

            //Total Coins
            Console.WriteLine("Total Coins: " + total);
            //Fee Amount
            Console.WriteLine("Fee Amount: " + fee);
            //Total
            Console.WriteLine("Total: " + totalFee);

        }
    }
}
