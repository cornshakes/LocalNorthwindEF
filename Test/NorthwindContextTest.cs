using LocalNorthwindEF;
using LocalNorthwindEF.Tables;

namespace Test
{
    public class NorthwindContextTest
    {
        [Fact]
        public void SimpleNorthwindContextWorks()
        {
            // Ensure the database file is created
            // and the data is copied from the embedded resource
            if (File.Exists("northwind.db"))
            {
                File.Delete("northwind.db");
            }
            using var context = new SimpleNorthwindContext();
            Assert.Equal(77, context.Products.Count());
        }

        [Fact]
        public void NorthwindContextWithViewsWorks()
        {
            // Ensure the database file is created
            // and the data is copied from the embedded resource
            if (File.Exists("northwind.db"))
            {
                File.Delete("northwind.db");
            }
            using var context = new NorthwindContextWithViews();
            Assert.Equal(69, context.AlphabeticalListOfProducts.Count());
        }

        [Fact]
        public void WritingWorks()
        {
            using (var context = new NorthwindContextWithViews())
            {
                var product = new Product
                {
                    ProductName = "Bunch a Bananas",
                    UnitPrice = 10.0,
                    UnitsInStock = 100
                };
                context.Products.Add(product);
                context.SaveChanges();
            }
            using (var context = new SimpleNorthwindContext())
            {
                var savedProduct = context.Products
                    .Where(p => p.ProductName == "Bunch a Bananas")
                    .FirstOrDefault();

                Assert.NotNull(savedProduct);
                Assert.NotEqual(0, savedProduct.ProductId);
                Assert.Equal("Bunch a Bananas", savedProduct.ProductName);
                Assert.Equal(10.0, savedProduct.UnitPrice);
                Assert.Equal(100, savedProduct.UnitsInStock);
            }
        }
    }
}
