using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCalculator
{
    class CoinCalculator
    {
        static void Main(string[] args)
        {
            InputHandler questionBook = new InputHandler();
            questionBook.questions();
            Output results = new Output();
            results.output();
            Console.ReadKey();
        }
    }
}
