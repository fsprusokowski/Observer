using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Class
{
    public class Stock
    {
        private int price;

        public string Name { get; set; }

        public int Value
        {
            get { return price; }
            set
            {
                price = value;
                NotifyAll();
            }
        }

        public int Notified { get; set; } = 0;

        public Stock (string name, int price)
        {
            Name = name;
            Value = price;
        }

        private List<Investor> Investors = new List<Investor>();

        public void NotifyAll()
        {
            foreach( var obs in Investors)
            {
                obs.Update();
                Notified++;
            }
        }

        public void attach(Investor investor)
        {
            Investors.Add(investor);
        }

        public int GetNumOfInvestors()
        {
            return Investors.Count();
        }
    }
}
