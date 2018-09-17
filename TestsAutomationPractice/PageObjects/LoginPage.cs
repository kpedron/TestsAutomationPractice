using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestsAutomationPractice.PageObjects
{
    class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "create-account_form")]
        public IWebElement createAccountForm { get; set; }

        [FindsBy(How = How.Id, Using = "email_create")]
        public IWebElement emailCreateInput { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement emailInput { get; set; }

        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement passwdInput { get; set; }

        [FindsBy(How = How.Id, Using = "SubmitCreate")]
        public IWebElement createButton { get; set; }

        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        public IWebElement loginButton { get; set; }

        public bool FindCreateAccountForm()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            return wait.Until(driver => createAccountForm.Displayed);
        }

        public void DoLogin(string email, string password)
        {
            emailInput.SendKeys(email);
            passwdInput.SendKeys(password);
        }

        public void SetEmail(string email)
        {
            emailCreateInput.SendKeys(email);
        }

        public void Confirm()
        {
            createButton.Click();
        }

        public void ConfirmLogin()
        {
            loginButton.Click();
        }
    }
}
