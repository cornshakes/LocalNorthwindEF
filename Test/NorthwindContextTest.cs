using LocalNorthwindEF;

namespace Test
{
    public class NorthwindContextTest
    {
        [Fact]
        public void SimpleNorthwindContextWorks()
        {
            var context = new SimpleNorthwindContext();
            Assert.Equal(77, context.Products.Count());
        }

        [Fact]
        public void NorthwindContextWithViewsWorks()
        {
            var context = new NorthwindContextWithViews();
            Assert.Equal(69, context.AlphabeticalListOfProducts.Count());
        }
    }
}
