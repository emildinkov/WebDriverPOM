namespace POMExercise.Tests
{
    public class CartTests : BaseTest
    {
        [SetUp]
        public void setUp()
        {
            Login("standard_user", "secret_sauce");
            inventoryPage.AddToCartByIndex(1);
            inventoryPage.ClickCartLink();
        }

        [Test]
        public void TestCartItemDisplayed()
        {
            Assert.That(cartPage.IsCartItemDisplayed(), Is.True, "There were no products in the cart");
        }

        [Test]
        public void TestClickCheckout() 
        {
            cartPage.ClickCheckoutButton();

            Assert.That(checkoutPage.IsPageLoaded(), Is.True, "Not navigated to the checkout page");
        }
    }
}
