using OpenQA.Selenium;

namespace SauceDemoTraining
{
    public class BasePage
    {
        public readonly IWebDriver _driver;
        public string _priceValue;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
            _priceValue = string.Empty;
        }

        public void NavigateToMainPage() => _driver.Navigate().GoToUrl(LocatorsAndUrls.LogInPageUrl);

        private void NavigateToCartPage() => _driver.FindElement(LocatorsAndUrls.CartButtonLocator).Click();

        public bool IsLoggedIn() => _driver != null && _driver.Url == LocatorsAndUrls.LoggedUserPageUrl;

        public bool IsNotLoggedIn() => _driver != null && _driver.Url == LocatorsAndUrls.LogInPageUrl;

        public bool IsSuccessfulPurchase() => _driver != null && _driver.Url == LocatorsAndUrls.SuccessfulPurchaseUrl;

        public void DataForSuccessfulLogIn(UserData userData)
        {
            _driver.FindElement(LocatorsAndUrls.UserNameFieldLocator).SendKeys(userData.UserName);
            _driver.FindElement(LocatorsAndUrls.PasswordFieldLocator).SendKeys(userData.UserPassword);
            _driver.FindElement(LocatorsAndUrls.LogInButtonLocator).Click();
        }

        public void DataForFailedLogIn(UserData userData)
        {
            _driver.FindElement(LocatorsAndUrls.UserNameFieldLocator).SendKeys(userData.UserName);
            _driver.FindElement(LocatorsAndUrls.PasswordFieldLocator).SendKeys(userData.IncorrectUserPassword);
            _driver.FindElement(LocatorsAndUrls.LogInButtonLocator).Click();
        }

        public void DataForPurchase(UserData userData)
        {
            _driver.FindElement(LocatorsAndUrls.AddToCartBikeLightLocator).Click();
            NavigateToCartPage();
            _driver.FindElement(LocatorsAndUrls.CheckOutButtonLocator).Click();
            _driver.FindElement(LocatorsAndUrls.FirstNameFieldLocator).SendKeys(userData.FirstName);
            _driver.FindElement(LocatorsAndUrls.LastNameFieldLocator).SendKeys(userData.LastName);
            _driver.FindElement(LocatorsAndUrls.PostalCodeFieldLocator).SendKeys(userData.PostalCode);
            _driver.FindElement(LocatorsAndUrls.ContinueButtonLocator).Click();
            _driver.FindElement(LocatorsAndUrls.FinishButtonLocator).Click();
        }

        public void DataForCartAdding()
        {
            _driver.FindElement(LocatorsAndUrls.AddToCartBikeLightLocator).Click();
            NavigateToCartPage();
        }

        public void DataForCartDeleting()
        {
            _driver.FindElement(LocatorsAndUrls.AddToCartBikeLightLocator).Click();
            NavigateToCartPage();
            _driver.FindElement(LocatorsAndUrls.RemoveFromCartButtonLocator).Click();
        }

        public bool IsAddedToCart()
        {
            try
            {
                return _driver.FindElement(LocatorsAndUrls.RemoveFromCartButtonLocator) != null;
            }
            catch
            {
                return false;
            }
        }
    }
}