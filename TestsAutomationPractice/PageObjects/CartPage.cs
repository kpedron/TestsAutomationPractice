using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestsAutomationPractice.PageObjects
{
    class CartPage
    {
        private IWebDriver driver;

        public CartPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        
        [FindsBy(How = How.Id, Using = "cart_summary")]
        public IWebElement cartSummaryTable { get; set; }

        [FindsBy(How = How.Id, Using = "total_product")]
        public IWebElement findProductPrice { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/p[2]/a[1]")]
        public IWebElement goToCheckoutButton { get; set; }

        public bool FindCartSummaryTable()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            return wait.Until(driver => cartSummaryTable.Displayed);
        }

        public string GetProductPrice()
        {
            return findProductPrice.Text;
        }

        public void ProceedToCheckout()
        {
            goToCheckoutButton.Click();
        }
    }
}
