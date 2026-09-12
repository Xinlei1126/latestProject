using ProductList;

ProductManager manager = new ProductManager();

Console.WriteLine("Enter specific information according to the displayed prompt from each step. ");
Console.WriteLine("Enter 'q' to quit. ");


while (true)
{
    // Category
    Console.Write("Enter Category: ");
    string category = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(category))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: Category cannot be empty.");
        Console.ResetColor();

        continue;
    }

    if (category.ToLower() == "q")
    {
        break;
    }

    // Product Name
    string name;

    while (true)
    {
        Console.Write("Enter Product Name: ");
        name = Console.ReadLine();

        // Check for empty product name
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: Product name cannot be empty.");
            Console.ResetColor();

            // Ask for product name again
            continue;
        }

        break;
    }

    // Price
    decimal price;

    while (true)
    {
        Console.Write("Enter Price: ");
        string priceInput = Console.ReadLine();

        // Check for invalid price
        if (!decimal.TryParse(priceInput, out price))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: Please enter a valid number.");
            Console.ResetColor();

            continue;
        }

        // Check for negative price
        if (price < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: Price cannot be negative.");
            Console.ResetColor();

            continue;
        }

        break;
    }

    Product product = new Product(category, name, price);

    manager.AddProduct(product);
}

// Show products
manager.ShowProducts();

decimal total = manager.CalculateTotal();
int tableWidth = manager.GetTableWidth();

string totalText = $"TOTAL PRICE: {total} kr";

Console.WriteLine();
Console.WriteLine(new string('-', tableWidth));
Console.WriteLine(totalText);
Console.WriteLine(new string('-', totalText.Length));

Console.WriteLine("Press any key to exit...");
Console.ReadKey();