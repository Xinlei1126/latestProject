using System;
using System.Collections.Generic;
using System.Linq;

namespace AssetTracking
{
    internal class Tracker
    {
        // Stores all company assets.
        private List<Asset> assets = new List<Asset>();

        // Adds an asset to the list.
        public void AddAsset(Asset asset)
        {
            assets.Add(asset);
        }

        // Displays all assets.
        public void PrintAssets()
        {
            // Level 3 requirement:
            // sort by Office first, then Purchase Date.
            List<Asset> sortedAssets = assets
                .OrderBy(asset => asset.Office.Name)
                .ThenBy(asset => asset.PurchaseDate)
                .ToList();

            Console.WriteLine();
            Console.WriteLine("ASSET LIST");
            Console.WriteLine();

            Console.WriteLine(
                $"{"Office",-10}" +
                $"{"Type",-12}" +
                $"{"Brand",-12}" +
                $"{"Model",-16}" +
                $"{"Price",-15}" +
                $"{"Purchase Date",-16}" +
                $"{"Status",-10}");

            Console.WriteLine(new string('-', 91));

            foreach (Asset asset in sortedAssets)
            {
                decimal localPrice = asset.GetLocalPrice();

                string priceText =
                    $"{localPrice:0.00} {asset.Office.Currency}";

                Console.Write(
                    $"{asset.Office.Name,-10}" +
                    $"{asset.Type,-12}" +
                    $"{asset.Brand,-12}" +
                    $"{asset.Model,-16}" +
                    $"{priceText,-15}" +
                    $"{asset.PurchaseDate,-16:yyyy-MM-dd}");

                PrintStatus(asset.GetStatus());

                Console.WriteLine();
            }
        }

        // Prints warning status using console colors.
        private void PrintStatus(string status)
        {
            ConsoleColor originalColor = Console.ForegroundColor;

            if (status == "RED")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (status == "YELLOW")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

            Console.Write($"{status,-10}");

            // Restore normal console color.
            Console.ForegroundColor = originalColor;
        }
    }
}
