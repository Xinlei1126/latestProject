using System;
using System.Collections.Generic;
using System.Text;

namespace AssetTracking
{
    internal class Computer : Asset
    {
        public Computer(
            Price price,
            DateTime purchaseDate,
            string brand,
            string model,
            Office office)
            : base(
                price,
                purchaseDate,
                brand,
                model,
                office,
                "Computer")
        {
        }
    }
}
