using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLabWeekly49
{
    // Phone class inherits from Product
    public class MobilePhone : Product
    {
        public MobilePhone(string name, DateTime purchaseDate, Office office, double priceUSD)
            : base(name, purchaseDate, office, priceUSD) { }

        // Override the Display method to include type of asset
        public override void Display()
        {
            Console.Write("Phone - ");
            base.Display();
        }
    }
}
