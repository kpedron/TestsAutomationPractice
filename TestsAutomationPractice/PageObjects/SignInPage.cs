using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestsAutomationPractice.PageObjects
{
    class SignInPage
    {
        private IWebDriver driver;

        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        /* FindsBy to Personal User Information */ 
        [FindsBy(How = How.Id, Using = "account-creation_form")]
        public IWebElement accountCreationForm { get; set; }

        [FindsBy(How = How.Id, Using = "uniform-id_gender2")]
        public IWebElement mrsRadio { get; set; }
    
        [FindsBy(How = How.Id, Using = "uniform-id_gender1")]
        public IWebElement mrRadio { get; set; }

        [FindsBy(How = How.Id, Using = "customer_firstname")]
        public IWebElement firstNameInput { get; set; }

        [FindsBy(How = How.Id, Using = "customer_lastname")]
        public IWebElement lastNameInput { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement emailInput { get; set; }

        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement passwdInput { get; set; }

        [FindsBy(How = How.Id, Using = "days")]
        public IWebElement daySelect { get; set; }

        [FindsBy(How = How.Id, Using = "months")]
        public IWebElement monthSelect { get; set; }

        [FindsBy(How = How.Id, Using = "years")]
        public IWebElement yearSelect { get; set; }

        [FindsBy(How = How.Id, Using = "newsletter")]
        public IWebElement newsletterCheckbox { get; set; }

        /* FindsBy to Address User Information */
        [FindsBy(How = How.Id, Using = "address1")]
        public IWebElement addressFirstInput { get; set; }

        [FindsBy(How = How.Id, Using = "city")]
        public IWebElement cityInput { get; set; }

        [FindsBy(How = How.Id, Using = "id_state")]
        public IWebElement stateSelect { get; set; }

        [FindsBy(How = How.Id, Using = "postcode")]
        public IWebElement postCodeInput { get; set; }

        [FindsBy(How = How.Id, Using = "id_country")]
        public IWebElement countryInput { get; set; }

        [FindsBy(How = How.Id, Using = "phone_mobile")]
        public IWebElement phoneInput { get; set; }

        [FindsBy(How = How.Id, Using = "submitAccount")]
        public IWebElement registerButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".alert.alert-danger")]
        public IWebElement alertDangerMessage { get; set; }

        public bool FindAccountCreation()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            return wait.Until(driver => accountCreationForm.Displayed);
        }

        public void SetGenderFemale(string type)
        {
            /* False is to Mr. ~ True is to Mrs. */
            if (String.Compare(type, "mrs") == 0)
            {
                mrsRadio.Click();
            } else
            {
                mrRadio.Click();
            }
        }

        public void SetName(string first, string last)
        {
            firstNameInput.SendKeys(first);
            lastNameInput.SendKeys(last);
        }

        public void SetLogin(string email, string password)
        {
            emailInput.Clear();
            emailInput.SendKeys(email);
            passwdInput.SendKeys(password);
        }

        public void SetPassword(string password)
        { 
            passwdInput.SendKeys(password);
        }

        public SelectElement GetSelect(IWebElement element)
        {
            SelectElement select = new SelectElement(element);
            return select;
        }

        public void SetDateBirth(string day, string month, string year)
        {
            GetSelect(daySelect).SelectByValue(day);
            GetSelect(monthSelect).SelectByValue(month);
            GetSelect(yearSelect).SelectByValue(year);
        }

        public void SetNewsletter(bool enable)
        {
            if (enable)
            {
                newsletterCheckbox.Click();
            }
        }

        public void SetAddress(string address, string city, string state)
        {
            addressFirstInput.SendKeys(address);
            cityInput.SendKeys(city);
            GetSelect(stateSelect).SelectByText(state);
        }

        public void SetCountry(string zip, string country_id)
        {
            postCodeInput.Clear();
            postCodeInput.SendKeys(zip);
            GetSelect(countryInput).SelectByValue(country_id);
        }

        public void SetMobile(string phone)
        {
            phoneInput.SendKeys(phone);
        }

        public bool ApplyWithError()
        {
            registerButton.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            return wait.Until(driver => alertDangerMessage.Displayed);
        }

        public void ConfirmNewUser()
        {
            registerButton.Click();
        }
    }
}
