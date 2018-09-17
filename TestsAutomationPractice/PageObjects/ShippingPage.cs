using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsAutomationPractice.PageObjects
{
    class ShippingPage
    {
        private IWebDriver driver;

        public ShippingPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "cgv")]
        public IWebElement termsCheckbox { get; set; }

        [FindsBy(How = How.Name, Using = "processCarrier")]
        public IWebElement checkoutButton { get; set; }

        public void EnableTermsService(bool option)
        {
            if (option)
            {
                termsCheckbox.Click();
            }
        }

        public void ProceedCheckout()
        {
            checkoutButton.Click();
        }
    }
}
