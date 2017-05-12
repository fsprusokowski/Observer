using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Class
{
    public abstract class Investor
    {
        protected Stock Stock { get; set; }

        public abstract void Update();
    }
}
