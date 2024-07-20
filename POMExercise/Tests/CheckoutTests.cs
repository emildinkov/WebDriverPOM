namespace POMExercise.Tests
{
    public class CheckoutTests : BaseTest
    {
        [SetUp]
        public void setUp()
        {
            Login("standard_user", "secret_sauce");
            inventoryPage.AddToCartByIndex(1);
            inventoryPage.ClickCartLink();
            cartPage.ClickCheckoutButton();
        }

        [Test]
        public void TestCheckoutPageLoaded()
        {
            Assert.That(checkoutPage.IsPageLoaded, Is.True, "Checkout page is not loaded");
        }

        [Test]
        public void TestContinueToNextStep()
        {
            checkoutPage.FillFirstName("Emil");
            checkoutPage.FillLastName("Dinkov");
            checkoutPage.FillPostalCode("1000");
            checkoutPage.ClickContinueButton();

            Assert.That(driver.Url.Contains("https://www.saucedemo.com/checkout-step-two.html"), Is.True, "Not navigated to the correct checkout page");
        }

        [Test]
        public void TestCompleteOrder()
        {
            checkoutPage.FillFirstName("Emil");
            checkoutPage.FillLastName("Dinkov");
            checkoutPage.FillPostalCode("1000");
            checkoutPage.ClickContinueButton();
            checkoutPage.ClickFinishButton();

            Assert.That(checkoutPage.IsCheckoutComplete, Is.True, "Checkout was not complited");
        }
    }
}
