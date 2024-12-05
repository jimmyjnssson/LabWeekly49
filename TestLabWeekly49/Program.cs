using System.Numerics;

namespace TestLabWeekly49
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create offices
            Office usa = new Office("USA", "USD");
            Office sweden = new Office("Sweden", "SEK");
            Office germany = new Office("Germany", "EUR");

            // Create a list of Computers and Phones with prices in set to USD
            List<Product> product= new List<Product>
            {
                new Computer("Dell Laptop 125", new DateTime(2021, 3, 15), usa, 1000),
                new MobilePhone("Samsung Galaxy S6", new DateTime(2020, 5, 20), sweden, 800),
                new Computer("IBM Quantum", new DateTime(2022, 7, 1), germany, 1500),
                new Computer("Inet Home Pro", new DateTime(2023, 7, 1), germany, 1500),
                new Computer("NZXT Max", new DateTime(2021, 7, 1), germany, 1500),
                new Computer("MacBook Pro", new DateTime(2020, 7, 1), germany, 1500),
                new MobilePhone("iPhone 13", new DateTime(2021, 11, 10), usa, 1200),
                new MobilePhone("iPhone 15 Pro Max", new DateTime(2019, 12, 5), germany, 700),
                new MobilePhone("Google Pixel 8", new DateTime(2021, 7, 5), germany, 700)
            };

            // Sort the list first by office, then by purchase date
            var sortedAssets = product
                .OrderBy(a => a is Computer ? 0 : 1)    // Sort by asset type: 0 for Computer and1 for Phone
                .ThenBy(a => a.PurchaseDate)             // Then sort by purchase date
                .ThenBy(a => a.Office.Location)          // Sort by office location
                .ToList();

            // Date when the asset is 3 years old
            DateTime threeYearsAgo = DateTime.Now.AddYears(-3);

            // Loop through sorted assets and display them
            foreach (var asset in sortedAssets)
            {
                bool isNearThree = (threeYearsAgo - asset.PurchaseDate).TotalDays <= 90;
                bool isNearSix = (threeYearsAgo - asset.PurchaseDate).TotalDays <= 180;

                // Display in red if the asset is less than 3 months away from 3 years
                if (isNearThree)
                {
                    Console.ForegroundColor = ConsoleColor.Red;  // Set console text to red
                }
                // Display in yellow if the asset is less than 6 months away from 3 years
                else if (isNearSix)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;  // Set console text to yellow
                }
                else
                {
                    Console.ResetColor();  // Reset to default color
                }

                // Display the asset details
                asset.Display();
                Console.ResetColor();  // Reset color after each display
            }
        }
    }
}

