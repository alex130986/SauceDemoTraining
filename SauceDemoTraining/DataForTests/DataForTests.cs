using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System.Diagnostics;

namespace SauceDemoTraining
{
    public class DataForTests
    {
        public readonly IWebDriver _driver;
        public string _priceValue;
        public readonly By _userNameFieldLocator = By.XPath("//input[@id='user-name']");
        public readonly By _passwordFieldLocator = By.XPath("//input[@id='password']");
        public readonly By _logInButtonLocator = By.XPath("//input[@id='login-button']");
        public const string LogInPageUrl = "https://www.saucedemo.com/";
        public const string LoggedUserPageUrl = "https://www.saucedemo.com/inventory.html";
        public const string SuccesfullPurchase = "https://www.saucedemo.com/checkout-complete.html";


        public DataForTests(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateToMainPage()
        {
            _driver.Navigate().GoToUrl(LogInPageUrl);
        }

        private void NavigateToCartPage()
        {
            var cartButton = _driver.FindElement(By.CssSelector(".shopping_cart_container .shopping_cart_link"));
            cartButton.Click();
        }

        public bool IsLoggedIn()
        {
            return _driver != null && _driver.Url == LoggedUserPageUrl;
        }

        public bool IsNotLoggedIn()
        {
            return _driver != null && _driver.Url == LogInPageUrl;
        }

        public bool IsSuccesfullPurchase()
        {
            return _driver != null && _driver.Url == SuccesfullPurchase;
        }

        public void DataForSuccesfullLogIn(UserData userData)
        {
            var userNameField = _driver.FindElement(_userNameFieldLocator);
            userNameField.SendKeys(userData.UserName);

            var passwordField = _driver.FindElement(_passwordFieldLocator);
            passwordField.SendKeys(userData.UserPassword);

            var logInButton = _driver.FindElement(_logInButtonLocator);
            logInButton.Click();
        }

        public void DataForFailedLogIn(UserData userData)
        {
            var userNameField = _driver.FindElement(_userNameFieldLocator);
            userNameField.SendKeys(userData.UserName);

            var passwordField = _driver.FindElement(_passwordFieldLocator);
            passwordField.SendKeys(userData.IncorrectUserPassword);

            var logInButton = _driver.FindElement(_logInButtonLocator);
            logInButton.Click();
        }

        public void DataForPurchase(UserData userData)
        {
            var addToCartRandomProduct = _driver.FindElement(By.XPath("//button[@id='add-to-cart-sauce-labs-bike-light']"));
            addToCartRandomProduct.Click();

            NavigateToCartPage();

            var checkOutButton = _driver.FindElement(By.XPath("//button[@id='checkout']"));
            checkOutButton.Click();

            var firstName = _driver.FindElement(By.XPath("//input[@id='first-name']"));
            firstName.SendKeys(userData.FirstName);

            var lastName = _driver.FindElement(By.XPath("//input[@id='last-name']"));
            lastName.SendKeys(userData.LastName);

            var postalCode = _driver.FindElement(By.XPath("//input[@id='postal-code']"));
            postalCode.SendKeys(userData.PostalCode);

            var continueButton = _driver.FindElement(By.XPath("//input[@id='continue']"));
            continueButton.Click();

            var finishButton = _driver.FindElement(By.XPath("//button[@id='finish']"));
            finishButton.Click();
        }

        public void DataForCartAdding()
        {
            var addToCartRandomProduct = _driver.FindElement(By.XPath("//button[@id='add-to-cart-sauce-labs-bike-light']"));
            addToCartRandomProduct.Click();

            NavigateToCartPage();
        }

        public void DataForCartDeleting()
        {
            var addToCartRandomProduct = _driver.FindElement(By.XPath("//button[@id='add-to-cart-sauce-labs-bike-light']"));
            addToCartRandomProduct.Click();

            NavigateToCartPage();

            var deleteProductFromCart = _driver.FindElement(By.XPath("//button[@class='btn btn_secondary btn_small cart_button']"));
            deleteProductFromCart.Click();
        }

        public bool IsAddedToCart()
        {
            try
            {
                var cartButton = _driver.FindElement(By.XPath("//button[@class='btn btn_secondary btn_small cart_button']"));
                return cartButton != null;
            }
            catch
            {
                return false;
            }
        }
    }
}