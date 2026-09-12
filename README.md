# latestProject
Update the lastest miniproject for Week 37.

# Product List

A simple **C# .NET console application** for creating and displaying a list of products.

Users can enter a product's category, name, and price. When finished, the application displays the products sorted from the lowest to highest price and calculates the total price.

## Features

* Add products with a category, name, and price
* Validate empty product names and categories
* Validate prices and prevent negative values
* Sort products from lowest to highest price
* Display products in a formatted table
* Calculate the total price of all products

## Requirements

Before running the application, make sure you have the following installed:

* [Git](https://git-scm.com/)
* [.NET 10 SDK](https://dotnet.microsoft.com/download)

You can check whether .NET is installed by opening a terminal and running:

```bash
dotnet --version
```

The installed version should be **10.0** or later.

## Installation

### 1. Clone the repository

Open a terminal and run:

```bash
git clone https://github.com/Xinlei1126/latestProject.git
```

### 2. Navigate to the project

```bash
cd latestProject/ProductList/ProductList
```

### 3. Restore the project

Run:

```bash
dotnet restore
```

This restores any dependencies required by the project.

## Running the Application

From the `ProductList/ProductList` directory, run:

```bash
dotnet run
```

The application will start directly in the terminal.

You should see:

```text
Enter specific information according to the displayed prompt from each step.
Enter 'q' to quit.

Enter Category:
```

## How to Use

Follow the prompts in the terminal.

### 1. Enter a category

For example:

```text
Enter Category: Electronics
```

### 2. Enter a product name

```text
Enter Product Name: Keyboard
```

### 3. Enter a price

```text
Enter Price: 499
```

After entering the information, the product is added to the list.

```text
Product added successfully!
```

You can continue adding as many products as you want.

### 4. Finish adding products

When the program asks for another category, enter:

```text
q
```

The application will then display all entered products, sorted by price, followed by their total price.

Example:

```text
           ===== PRODUCT LIST =====
Category      Product Name            Price
-------------------------------------------
Electronics   Mouse                   199 kr
Electronics   Keyboard                499 kr
Electronics   Monitor                2499 kr

-------------------------------------------
TOTAL PRICE: 3197 kr
--------------------
Press any key to exit...
```

Press any key to close the application.

## Project Structure

```text
latestProject/
├── README.md
└── ProductList/
    ├── ProductList.slnx
    └── ProductList/
        ├── ProductList.csproj
        ├── Program.cs
        ├── Product.cs
        └── ProductManager.cs
```

### Main Files

* `Program.cs` — handles user input and runs the application
* `Product.cs` — represents a product with category, name, and price
* `ProductManager.cs` — manages products, sorting, displaying, and total price calculation
* `ProductList.csproj` — contains the .NET project configuration

## Quick Start

For users who already have Git and .NET 10 installed:

```bash
git clone https://github.com/Xinlei1126/latestProject.git
cd latestProject/ProductList/ProductList
dotnet restore
dotnet run
```

## Technologies

* C#
* .NET 10
* Git
* GitHub
