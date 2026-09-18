using System;
using System.Collections.Generic;
using System.Text;

namespace AssetTracking
{
    // Represents an office and the currency used there.
    internal class Office
    {
        public string Name { get; set; }
        public Currency Currency { get; set; }

        public Office(string name, Currency currency)
        {
            Name = name;
            Currency = currency;
        }
    }
}
