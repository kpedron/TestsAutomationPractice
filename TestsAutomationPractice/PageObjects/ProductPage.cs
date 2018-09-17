using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestsAutomationPractice.PageObjects
{
    class ProductPage
    {
        private IWebDriver driver;

        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "Submit")]
        public IWebElement addCartSubmit { get; set; }

        [FindsBy(How = How.Id, Using = "layer_cart")]
        public IWebElement productAdded { get; set; }

        [FindsBy(How = How.LinkText, Using = "Proceed to checkout")]
        public IWebElement checkoutButton { get; set; }

        public void NavigateToProductPage(string id)
        {
            string url = "http://automationpractice.com/index.php?id_product=" + id + "&controller=product";
            driver.Navigate().GoToUrl(url); ;
        }

        public void SelectProduct()
        {
            addCartSubmit.Click();
        }

        public bool FindCartSummary()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            return wait.Until(driver => productAdded.Displayed);
        }
   
        public void Confirm()
        {
            checkoutButton.Click();
        }
    }
}
