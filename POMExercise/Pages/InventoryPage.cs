using OpenQA.Selenium;

namespace POMExercise.Pages
{
    public class InventoryPage : BasePage
    {
        // Create Locators for elements
        protected readonly By productsPageTitle = By.XPath("//span[@data-test='title']");

        protected readonly By cartLink = By.XPath("//a[@data-test='shopping-cart-link']");

        protected readonly By productItems = By.XPath("//div[@data-test='inventory-item']");
        public InventoryPage(IWebDriver driver) : base(driver)
        {
        }

        // Create method for Add to Cart By Index
        public void AddToCartByIndex(int itemIndex)
        {
            var addButtonByItemIndex = By.XPath($"//div[@data-test='inventory-item'][{itemIndex}]//button");

            Click(addButtonByItemIndex);
        }

        // Create method for Add to cart By Name
        public void AddToCartByName(string nameProduct)
        {
            var itemByNameButton = By.XPath($"//div[text()='{nameProduct}']/ancestor::div[@class='inventory_item_description']//button");

            Click(itemByNameButton);
        }

        // Method for Click Cart
        public void ClickCartLink()
        {
            Click(cartLink);
        }

        // Method for validation some products are displayed
        public bool IsInventoryPageHasItemsDisplayed()
        {
            return FindElements(productItems).Any();
        }

        // Method for check whether page is correct loaded
        public bool IsInventoryPageLoaded()
        {
            return GetText(productsPageTitle) == "Products" && driver.Url.Contains("inventory.htm");
        }
    }
}
