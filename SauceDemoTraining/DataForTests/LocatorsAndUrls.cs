using OpenQA.Selenium;

namespace SauceDemoTraining
{
    public static class LocatorsAndUrls
    {
        // Login page
        public static readonly By UserNameFieldLocator = By.XPath("//input[@id='user-name']");
        public static readonly By PasswordFieldLocator = By.XPath("//input[@id='password']");
        public static readonly By LogInButtonLocator = By.XPath("//input[@id='login-button']");

        // Cart
        public static readonly By CartButtonLocator = By.CssSelector(".shopping_cart_container .shopping_cart_link");
        public static readonly By AddToCartBikeLightLocator = By.XPath("//button[@id='add-to-cart-sauce-labs-bike-light']");
        public static readonly By RemoveFromCartButtonLocator = By.XPath("//button[@class='btn btn_secondary btn_small cart_button']");

        // Checkout
        public static readonly By CheckOutButtonLocator = By.XPath("//button[@id='checkout']");
        public static readonly By FirstNameFieldLocator = By.XPath("//input[@id='first-name']");
        public static readonly By LastNameFieldLocator = By.XPath("//input[@id='last-name']");
        public static readonly By PostalCodeFieldLocator = By.XPath("//input[@id='postal-code']");
        public static readonly By ContinueButtonLocator = By.XPath("//input[@id='continue']");
        public static readonly By FinishButtonLocator = By.XPath("//button[@id='finish']");

        // URLs
        public const string LogInPageUrl = "https://www.saucedemo.com/";
        public const string LoggedUserPageUrl = "https://www.saucedemo.com/inventory.html";
        public const string SuccessfulPurchaseUrl = "https://www.saucedemo.com/checkout-complete.html";
    }
}