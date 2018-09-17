using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsAutomationPractice.PageObjects
{
    class AddressPage
    {
        private IWebDriver driver;

        public AddressPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        /* The position 3 will be the street*/
        [FindsBy(How = How.XPath, Using = "//*[@id='address_delivery']/li[3]")]
        public IWebElement findStreet { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address_delivery']/li[4]")]
        public IWebElement findCityState { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address_delivery']/li[5]")]
        public IWebElement findCountry { get; set; }

        [FindsBy(How = How.Name, Using = "processAddress")]
        public IWebElement checkoutButton { get; set; }

        public string GetStreet()
        {
            return findStreet.Text;
        }
    
        public string GetCityState()
        {
            return findCityState.Text;
        }

        public string GetCountry()
        {
            return findCountry.Text;
        }

        public void ProceedCheckout()
        {
            checkoutButton.Click();
        }
    }
}
