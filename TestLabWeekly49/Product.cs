using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLabWeekly49
{
    // Base class for Asset
    public class Product
    {
        public string Name { get; set; }
        public DateTime PurchaseDate { get; set; }
        public Office Office { get; set; }
        public double PriceInUSD { get; set; }

        public Product(string name, DateTime purchaseDate, Office office, double priceUSD)
        {
            Name = name;
            PurchaseDate = purchaseDate;
            Office = office;
            PriceInUSD = priceUSD;
        }

        // Method to get the price in local currency
        public double GetLocalPrice()
        {
            return Office.ConvertFromUSD(PriceInUSD);
        }

        // Virtual method to display the asset (to be overridden by subclasses)
        public virtual void Display()
        {
            Console.WriteLine($"{Name} - Date: {PurchaseDate.ToString("yyyy-MM-dd")} - " + $"{PriceInUSD:F2} USD - " +
                "Local: " + $"{GetLocalPrice():F2} ({Office.Currency}) - Office: {Office.Location}");
            
        }
    }
}

