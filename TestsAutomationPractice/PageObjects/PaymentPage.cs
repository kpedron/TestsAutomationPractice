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
    class PaymentPage
    {
        private IWebDriver driver;

        public PaymentPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "total_price")]
        public IWebElement totalSpan{ get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Pay by bank wire")]
        public IWebElement bankPayment { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Pay by check")]
        public IWebElement checkPayment { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='cart_navigation']/button")]
        public IWebElement confirmOrderButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/div/p/strong")]
        public IWebElement successMessage { get; set; }

        public string GetTotalPrice()
        {
            return totalSpan.Text;
        }

        public void PayByBankWire()
        {
            bankPayment.Click();
        }

        public void PayByCheck()
        {
            checkPayment.Click();
        }

        public void ConfirmOrder()
        {
            confirmOrderButton.Click();
        }

        public string FindPaymentSuccess()
        {
            return successMessage.Text;
        }
    }
}
