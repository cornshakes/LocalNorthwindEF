# Entity Framework Practice Kit With Northwind Sample DB

LocalNorthwindEF is a self contained Northwind db to practice Entity Framework skills.
You don't have to connect it to a database first, instead you can just start.

It uses a pre-generated northwind.db sqlite file from [northwind-SQLite3](https://github.com/jpwhite3/northwind-SQLite3) by [@jpwhite3](https://github.com/jpwhite3).

It creates a new northwind.db file in the build folder if there isn't one.
Cleaning or rebuilding the project will reset your database!
Copy it out of the build folder first if you want to keep it.

[EF Core Power Tools](https://marketplace.visualstudio.com/items?itemName=ErikEJ.EFCorePowerTools) were used to generate all the model & context classes.

## Usage

Install the nuget package [LocalNorthwindEF](https://www.nuget.org/packages/LocalNorthwindEF/).

There is the simple context which contains all the tables:

```csharp
using var context = new SimpleNorthwindContext();
var customers = context.Customers.ToList();
...
```

If you want to use the views too, use the extended context:

```csharp
using var context = new NorthwindContextWithViews();
var products = context.AlphabeticalListOfProducts.ToList();
...
```
