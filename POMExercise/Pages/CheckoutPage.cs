using OpenQA.Selenium;

namespace POMExercise.Pages
{
    public class CheckoutPage : BasePage
    {
        // Create Locators for Elements
        protected readonly By firstNameField = By.Id("first-name");

        protected readonly By lastNameField = By.Id("last-name");

        protected readonly By postalCodeField = By.Id("postal-code");

        protected readonly By continueButton = By.Id("continue");

        protected readonly By finishButton = By.Id("finish");

        protected readonly By completeHeader = By.XPath("//h2[@class='complete-header']");
        public CheckoutPage(IWebDriver driver) : base(driver)
        {
        }

        // Create method for Fill firstname
        public void FillFirstName(string firstname)
        {
            Type(firstNameField, firstname);
        }

        // Create method for Fill lastname
        public void FillLastName(string lastname)
        {
            Type(lastNameField, lastname);
        }

        // Create method for Fill postalcode
        public void FillPostalCode(string postalCode)
        {
            Type(postalCodeField, postalCode);
        }

        // Method for click Continue button
        public void ClickContinueButton()
        {
            Click(continueButton);
        }

        // Method for click Finish button
        public void ClickFinishButton()
        {
            Click(finishButton);
        }

        // Method for check whether page is correct loaded
        public bool IsPageLoaded()
        {
            return driver.Url.Contains("https://www.saucedemo.com/checkout-step-one.html") || driver.Url.Contains("https://www.saucedemo.com/checkout-step-two.html");
        }

        // Method for checking whether finish tex is correct
        public bool IsCheckoutComplete()
        {
            return GetText(completeHeader) == "Thank you for your order!";
        }
    }
}
