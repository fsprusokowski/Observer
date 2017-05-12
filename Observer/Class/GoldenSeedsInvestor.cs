using System;

namespace Observer.Class
{
    public class GoldenSeedsInvestor : Investor
    {
        public GoldenSeedsInvestor()
        {
        }

        public GoldenSeedsInvestor(Stock stock)
        {
            Stock = stock;
            Stock.attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Golden Seeds Investor notified, {0} value is: {1}", this.Stock.Name, this.Stock.Value);

        }
    }
}
