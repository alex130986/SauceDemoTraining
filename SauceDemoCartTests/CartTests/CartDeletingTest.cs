using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using SauceDemoTraining;

namespace SauceDemoCartTests.CartTests
{

    [TestFixture]
    public class CartDeletingTest
    {
        public IWebDriver _driver;
        public BasePage _loggedInUser;

        [SetUp]
        public void SetUp()
        {
            _driver = new EdgeDriver();
            _loggedInUser = new BasePage(_driver);
            _driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void LogInExistingUser_ShouldAddProductToCartAndDelete()
        {
            // Arrange
            var userData = new UserData();

            // Act
            _loggedInUser.NavigateToMainPage();
            _loggedInUser.DataForSuccessfulLogIn(userData);
            _loggedInUser.DataForCartDeleting();

            // Assert
            bool isAddedToCart = _loggedInUser.IsAddedToCart();
            Assert.IsFalse(isAddedToCart, "Product should be deleted from the cart");
        }
    }
}