using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLabWeekly49
{
    // Computer class inherits from Product class
    public class Computer : Product
    {
        public Computer(string name, DateTime purchaseDate, Office office, double priceUSD)
            : base(name, purchaseDate, office, priceUSD) { }

        // Override the Display method to include the type
        public override void Display()
        {
            Console.Write("Computer - ");
            base.Display();
        }
    }
}
