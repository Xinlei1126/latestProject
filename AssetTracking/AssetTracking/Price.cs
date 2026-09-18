using System;
using System.Collections.Generic;
using System.Text;

namespace AssetTracking
{
    // Represents a price and its currency.
    internal class Price
    {
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }

        public Price(decimal amount, Currency currency)
        {
            Amount = amount;
            Currency = currency;
        }
    }
}
