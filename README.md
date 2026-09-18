# latestProject

Update the latest miniproject with the Asset Tracking application in week 38.

# Asset Tracking

A simple C# .NET console application for tracking company computers and smartphones across different offices.

The application stores asset information such as type, brand, model, purchase date, price, and office. It converts each asset's price to the local office currency, sorts assets by office and purchase date, and displays warning statuses for assets approaching or passing their three-year lifespan.

## Features

* Track computers and smartphones
* Store each asset's brand, model, purchase date, price, and office
* Assign assets to offices in the USA, Sweden, and Germany
* Support USD, SEK, and EUR currencies
* Convert asset prices to the local office currency using fixed exchange rates
* Sort assets first by office and then by purchase date
* Calculate a three-year end-of-life date for every asset
* Display RED and YELLOW warning statuses using console colors
* Display all assets in a formatted table

## Requirements

Before running the application, make sure you have the following installed:

* Git
* .NET 10 SDK

You can check whether .NET is installed by opening a terminal and running:

```bash
dotnet --version
```

The installed version should be 10.0 or later.

## Installation

### 1. Clone the repository

Open a terminal and run:

```bash
git clone https://github.com/Xinlei1126/latestProject.git
```

### 2. Navigate to the project

```bash
cd latestProject/AssetTracking/AssetTracking
```

### 3. Restore the project

Run:

```bash
dotnet restore
```

This restores any dependencies required by the project.

## Running the Application

From the `AssetTracking/AssetTracking` directory, run:

```bash
dotnet run
```

The application will start directly in the terminal and display the predefined company assets.

You should see a table similar to:

```text
ASSET LIST

Office    Type        Brand       Model           Price          Purchase Date   Status
-------------------------------------------------------------------------------------------
Germany   Computer    Asus        ROG 500         1300.00 EUR    YYYY-MM-DD      YELLOW
Sweden    Smartphone  Sony        XPeria 7        3000.00 SEK    YYYY-MM-DD      RED
USA       Computer    Dell        Desktop 900     100.00 USD     YYYY-MM-DD      RED
```

Purchase dates and warning statuses depend on the date when the application is run because the sample purchase dates are created relative to `DateTime.Now`.

## How to Use

The current version uses predefined sample data in `Program.cs`. You can change or add assets directly in the source code.

### 1. Create an office

Create an office and assign its local currency.

For example:

```csharp
Office sweden = new Office("Sweden", Currency.SEK);
```

### 2. Create an asset

Create either a `Computer` or a `Smartphone` with a price, purchase date, brand, model, and office.

```csharp
new Computer(
    new Price(1500, Currency.SEK),
    DateTime.Now.AddMonths(-29),
    "Dell",
    "Optiplex 100",
    sweden)
```

### 3. Add the asset to the tracker

Add the asset with `AddAsset`:

```csharp
tracker.AddAsset(
    new Smartphone(
        new Price(4500, Currency.SEK),
        DateTime.Now.AddMonths(-30),
        "Samsung",
        "Galaxy 10",
        sweden));
```

The tracker stores all assets in one list.

### 4. Display the assets

Call:

```csharp
tracker.PrintAssets();
```

The application will then:

* Sort assets by office name
* Sort assets within each office by purchase date
* Convert prices to the office's local currency
* Display the asset type, brand, model, local price, purchase date, and status
* Show warning statuses in RED or YELLOW in the terminal

Example:

```text
ASSET LIST

Office    Type        Brand       Model           Price          Purchase Date   Status
-------------------------------------------------------------------------------------------
Germany   Computer    Asus        ROG 500         1300.00 EUR    YYYY-MM-DD      YELLOW
Sweden    Smartphone  Samsung     Galaxy 10       4500.00 SEK    YYYY-MM-DD      RED
USA       Smartphone  Motorola    X3              200.00 USD     YYYY-MM-DD      RED
```

The currency converter currently uses fixed exchange rates rather than live currency data.

## Project Structure

```text
latestProject/
├── README.md
└── AssetTracking/
    ├── AssetTracking.slnx
    └── AssetTracking/
        ├── AssetTracking.csproj
        ├── Program.cs
        ├── Asset.cs
        ├── Computer.cs
        ├── Smartphone.cs
        ├── Tracker.cs
        ├── Office.cs
        ├── Price.cs
        ├── Currency.cs
        └── CurrencyConverter.cs
```

### Main Files

* `Program.cs` — creates the offices and sample assets, then starts the asset display
* `Asset.cs` — base class containing the properties and shared behavior for all assets
* `Computer.cs` — represents computer assets
* `Smartphone.cs` — represents smartphone assets
* `Tracker.cs` — stores, sorts, and displays company assets
* `Office.cs` — represents an office and its local currency
* `Price.cs` — represents an asset price and its original currency
* `Currency.cs` — defines the supported USD, SEK, and EUR currencies
* `CurrencyConverter.cs` — converts prices between supported currencies using fixed exchange rates
* `AssetTracking.csproj` — contains the .NET project configuration

## Quick Start

For users who already have Git and .NET 10 installed:

```bash
git clone https://github.com/Xinlei1126/latestProject.git
cd latestProject/AssetTracking/AssetTracking
dotnet restore
dotnet run
```

## Technologies

* C#
* .NET 10
* LINQ
* Git
* GitHub
