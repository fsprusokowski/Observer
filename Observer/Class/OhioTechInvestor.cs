using System;

namespace Observer.Class
{
    public class OhioTechInvestor : Investor
    {
        public OhioTechInvestor()
        {
        }

        public OhioTechInvestor(Stock stock)
        {
            Stock = stock;
            Stock.attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Ohio Investor notified, {0} value is: {1}", this.Stock.Name, this.Stock.Value);
        }
    }
}
