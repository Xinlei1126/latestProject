using AssetTracking;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AssetTracking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tracker tracker = new Tracker();

            // Create offices and assign their local currencies.
            Office usa = new Office("USA", Currency.USD);
            Office sweden = new Office("Sweden", Currency.SEK);
            Office germany = new Office("Germany", Currency.EUR);


            // ==========================================
            // SMARTPHONES
            // ==========================================

            tracker.AddAsset(
                new Smartphone(
                    new Price(200, Currency.USD),
                    DateTime.Now.AddMonths(-36 + 4),
                    "Motorola",
                    "X3",
                    usa));

            tracker.AddAsset(
                new Smartphone(
                    new Price(400, Currency.USD),
                    DateTime.Now.AddMonths(-36 + 5),
                    "Motorola",
                    "X3",
                    usa));

            tracker.AddAsset(
                new Smartphone(
                    new Price(400, Currency.USD),
                    DateTime.Now.AddMonths(-36 + 10),
                    "Motorola",
                    "X2",
                    usa));

            tracker.AddAsset(
                new Smartphone(
                    new Price(4500, Currency.SEK),
                    DateTime.Now.AddMonths(-36 + 6),
                    "Samsung",
                    "Galaxy 10",
                    sweden));

            tracker.AddAsset(
                new Smartphone(
                    new Price(4500, Currency.SEK),
                    DateTime.Now.AddMonths(-36 + 7),
                    "Samsung",
                    "Galaxy 10",
                    sweden));

            tracker.AddAsset(
                new Smartphone(
                    new Price(3000, Currency.SEK),
                    DateTime.Now.AddMonths(-36 + 4),
                    "Sony",
                    "XPeria 7",
                    sweden));

            tracker.AddAsset(
                new Smartphone(
                    new Price(3000, Currency.SEK),
                    DateTime.Now.AddMonths(-36 + 5),
                    "Sony",
                    "XPeria 7",
                    sweden));

            tracker.AddAsset(
                new Smartphone(
                    new Price(220, Currency.EUR),
                    DateTime.Now.AddMonths(-36 + 12),
                    "Siemens",
                    "Brick",
                    germany));


            // ==========================================
            // COMPUTERS
            // ==========================================

            tracker.AddAsset(
                new Computer(
                    new Price(100, Currency.USD),
                    DateTime.Now.AddMonths(-38),
                    "Dell",
                    "Desktop 900",
                    usa));

            tracker.AddAsset(
                new Computer(
                    new Price(100, Currency.USD),
                    DateTime.Now.AddMonths(-37),
                    "Dell",
                    "Desktop 900",
                    usa));

            tracker.AddAsset(
                new Computer(
                    new Price(300, Currency.USD),
                    DateTime.Now.AddMonths(-36 + 1),
                    "Lenovo",
                    "X100",
                    usa));

            tracker.AddAsset(
                new Computer(
                    new Price(300, Currency.USD),
                    DateTime.Now.AddMonths(-36 + 4),
                    "Lenovo",
                    "X200",
                    usa));

            tracker.AddAsset(
                new Computer(
                    new Price(500, Currency.USD),
                    DateTime.Now.AddMonths(-36 + 9),
                    "Lenovo",
                    "X300",
                    usa));

            tracker.AddAsset(
                new Computer(
                    new Price(1500, Currency.SEK),
                    DateTime.Now.AddMonths(-36 + 7),
                    "Dell",
                    "Optiplex 100",
                    sweden));

            tracker.AddAsset(
                new Computer(
                    new Price(1400, Currency.SEK),
                    DateTime.Now.AddMonths(-36 + 8),
                    "Dell",
                    "Optiplex 200",
                    sweden));

            tracker.AddAsset(
                new Computer(
                    new Price(1300, Currency.SEK),
                    DateTime.Now.AddMonths(-36 + 9),
                    "Dell",
                    "Optiplex 300",
                    sweden));

            tracker.AddAsset(
                new Computer(
                    new Price(1600, Currency.EUR),
                    DateTime.Now.AddMonths(-36 + 14),
                    "Asus",
                    "ROG 600",
                    germany));

            tracker.AddAsset(
                new Computer(
                    new Price(1200, Currency.EUR),
                    DateTime.Now.AddMonths(-36 + 4),
                    "Asus",
                    "ROG 500",
                    germany));

            tracker.AddAsset(
                new Computer(
                    new Price(1200, Currency.EUR),
                    DateTime.Now.AddMonths(-36 + 3),
                    "Asus",
                    "ROG 500",
                    germany));

            tracker.AddAsset(
                new Computer(
                    new Price(1300, Currency.EUR),
                    DateTime.Now.AddMonths(-36 + 2),
                    "Asus",
                    "ROG 500",
                    germany));


            // Sort and display all assets.
            tracker.PrintAssets();
        }
    }
}