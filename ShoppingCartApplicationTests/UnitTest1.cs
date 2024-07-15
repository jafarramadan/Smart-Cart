using ShoppingCartApplication;

namespace ShoppingCartApplicationTests
{
    public class UnitTest1
    {
        [Fact]
        public void checkAddItem()
        {
            //arrange
            ShoppingCart shoppingCart = new ShoppingCart();
            Product product =new Product("banan",10,ProductCategory.Food);
            //act
            shoppingCart.AddItems(product);
            //assert
            Assert.True(shoppingCart.AddItems(product));
        }
        [Fact]
        public void checkRemoveItem()
        {
            //arrange
            ShoppingCart shoppingCart = new ShoppingCart();
            Product product = new Product("aaa", 10, ProductCategory.Food);
            //act
            shoppingCart.AddItems(product);
            //assert
            Assert.True(shoppingCart.removeItems(product));
        }

        [Fact]

        public void checkCalculatePrice() 
        {
            //arrange
            ShoppingCart shoppingCart = new ShoppingCart();
            Product product1 = new Product("a", 10, ProductCategory.Food);
            Product product2 = new Product("b", 20, ProductCategory.Food);
            //act
            shoppingCart.AddItems(product1);
            shoppingCart.AddItems(product2);
            int total =shoppingCart.CalculateTotal();
            //assert
            Assert.Equal(total, 30);

        }
    }
}