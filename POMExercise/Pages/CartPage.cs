using OpenQA.Selenium;

namespace POMExercise.Pages
{
    public class CartPage : BasePage
    {
        // Create Locators for Elements
        protected readonly By cartItem = By.XPath("//div[@class='cart_item']");

        protected readonly By checkoutButton = By.Id("checkout");
        public CartPage(IWebDriver driver) : base(driver)
        {
        }

        // Create method whether have any item in the cart
        public bool IsCartItemDisplayed()
        {
            return FindElement(cartItem).Displayed;
        }

        // Create method for click checkout button
        public void ClickCheckoutButton()
        {
            Click(checkoutButton);
        }
    }
}
