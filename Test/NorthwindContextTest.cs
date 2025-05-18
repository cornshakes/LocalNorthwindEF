using LocalNorthwindEF;

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
            var context = new SimpleNorthwindContext();
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
            var context = new NorthwindContextWithViews();
            Assert.Equal(69, context.AlphabeticalListOfProducts.Count());
        }
    }
}
