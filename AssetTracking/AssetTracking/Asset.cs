using System;
using System.Collections.Generic;
using System.Text;

namespace AssetTracking
{
    // Base class containing properties shared by all assets.
    internal class Asset
    {
        public Price Price { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public Office Office { get; set; }
        public string Type { get; set; }

        public Asset(
            Price price,
            DateTime purchaseDate,
            string brand,
            string model,
            Office office,
            string type)
        {
            Price = price;
            PurchaseDate = purchaseDate;
            Brand = brand;
            Model = model;
            Office = office;
            Type = type;
        }

        // All assets have a lifespan of 3 years.
        public DateTime EndOfLifeDate
        {
            get
            {
                return PurchaseDate.AddYears(3);
            }
        }

        // Determines if the asset is getting close
        // to its 3-year end-of-life date.
        public string GetStatus()
        {
            DateTime today = DateTime.Now;
            DateTime endOfLife = EndOfLifeDate;

            // Asset has already passed its 3-year lifespan.
            if (today >= endOfLife)
            {
                return "RED";
            }

            // Less than 3 months remaining.
            if (today >= endOfLife.AddMonths(-3))
            {
                return "YELLOW";
            }

            // Between 3 and 6 months remaining.
            if (today >= endOfLife.AddMonths(-6))
            {
                return "RED";
            }

            return "";
        }

        // Converts the original price to the office currency.
        public decimal GetLocalPrice()
        {
            return CurrencyConverter.Convert(
                Price.Amount,
                Price.Currency,
                Office.Currency);
        }
    }
}
