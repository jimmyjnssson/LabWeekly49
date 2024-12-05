using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLabWeekly49
{

    
    public class Office
    {
        public string Location { get; set; }  
        public string Currency { get; set; }

        public Office(string location, string currency)
        {
            Location = location;
            Currency = currency;
        }

        // Convert price from USD to local currency (for demonstration purposes)
        public double ConvertFromUSD(double priceUSD)
        {
            double exchangeRateUSD = 1.0;
            double exchangeRateSum = 0;

            if (Location == "USA")
            {
                exchangeRateUSD = 1.0; // USD to USD
            }
            else if (Location == "Sweden")
            {
                exchangeRateUSD = 10.55; // USD to SEK
            }
            else if (Location == "Germany")
            {
                exchangeRateUSD = 0.9; // USD to EUR
            }

            exchangeRateSum = priceUSD * exchangeRateUSD;

            return exchangeRateSum;
        }
    }
}
