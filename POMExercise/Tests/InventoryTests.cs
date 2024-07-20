using POMExercise.Pages;

namespace POMExercise.Tests
{
    public class InventoryTests : BaseTest
    {
        [SetUp]
        public void setUp()
        {
            Login("standard_user", "secret_sauce");
        }
        [Test]
        public void TestInventoryDisplay()
        {
            Assert.That(inventoryPage.IsInventoryPageHasItemsDisplayed(), Is.True, "Inventory page has no items displayed");

            Assert.That(inventoryPage.IsInventoryPageLoaded(), Is.True, "Inventory page is not loaded");
        }

        [Test]
        public void TestAddToCartByIndex()
        {
            inventoryPage.AddToCartByIndex(1);

            inventoryPage.ClickCartLink();

            Assert.That(cartPage.IsCartItemDisplayed(), Is.True, "Cart item was not added in the cart");
        }

        [Test]
        public void TestAddToCartByName()
        {
            inventoryPage.AddToCartByName("Sauce Labs Bike Light");

            inventoryPage.ClickCartLink();

            Assert.That(inventoryPage.IsInventoryPageHasItemsDisplayed(), Is.True, "Cart item was not added in the cart");
        }

        [Test]
        public void TestPageTitle()
        {
            Assert.That(inventoryPage.IsInventoryPageLoaded(), Is.True, "Inventory page not loaded correctly");
        }
    }
}
