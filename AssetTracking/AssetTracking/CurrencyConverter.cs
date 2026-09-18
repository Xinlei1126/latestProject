using System;
using System.Collections.Generic;
using System.Text;

namespace AssetTracking
{
    // Handles currency conversion using hardcoded exchange rates.
    internal class CurrencyConverter
    {
        public static decimal Convert(
            decimal amount,
            Currency fromCurrency,
            Currency toCurrency)
        {
            // No conversion needed.
            if (fromCurrency == toCurrency)
            {
                return amount;
            }

            decimal amountInUSD;

            // Convert the original price to USD first.
            switch (fromCurrency)
            {
                case Currency.USD:
                    amountInUSD = amount;
                    break;

                case Currency.SEK:
                    amountInUSD = amount / 10.50m;
                    break;

                case Currency.EUR:
                    amountInUSD = amount / 0.92m;
                    break;

                default:
                    amountInUSD = amount;
                    break;
            }

            // Convert USD to the destination currency.
            switch (toCurrency)
            {
                case Currency.USD:
                    return amountInUSD;

                case Currency.SEK:
                    return amountInUSD * 10.50m;

                case Currency.EUR:
                    return amountInUSD * 0.92m;

                default:
                    return amountInUSD;
            }
        }
    }
}
