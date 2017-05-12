using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Class;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock("IBM", 100);
            var ohioTechInvestor = new OhioTechInvestor(stock);
            var goldenSeedsInvestor = new GoldenSeedsInvestor(stock);

            stock.Value = 180;
            Console.ReadKey();
        }
    }
}
