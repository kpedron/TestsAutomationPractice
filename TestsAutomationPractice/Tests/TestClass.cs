using NUnit.Framework;
using TestsAutomationPractice.PageObjects;

namespace TestsAutomationPractice
{
    public class TestClass : BaseConfig
    {
        [Test, Order(1)]
        public void SelectProduct()
        {
            ProductPage product = new ProductPage(BaseTest.driver);
            product.NavigateToProductPage(product_id);
            product.SelectProduct();
            Assert.IsTrue(product.FindCartSummary());
            product.Confirm();
        }

        [Test, Order(2)]
        public void ValidateCart()
        {
            CartPage cart = new CartPage(BaseTest.driver);
            Assert.IsTrue(cart.FindCartSummaryTable());
            Assert.AreEqual(cart.GetProductPrice(), product_price);
            cart.ProceedToCheckout();
        }

        /*
         * If you have a user who already exists, you can do login.
         * But, pay attention: the CreateLogin(), SetNewClientPersonalInfo
         * and SetNewClientAddressInfo won't be necessary, then comment these and
         * uncomment the DoLogin()
         * 
            [Test, Order(3)]
            public void DoLogin()
            {
                LoginPage login = new LoginPage(BaseTest.driver);
                login.DoLogin(user_email, passwd);
                login.ConfirmLogin();
            }
          *
          */

        [Test, Order(3)]
        public void CreateLogin()
        {
            LoginPage login = new LoginPage(BaseTest.driver);
            Assert.IsTrue(login.FindCreateAccountForm());
            login.SetEmail(user_email);
            login.Confirm();
        }

        [Test, Order(4)]
        public void SetNewClientPersonalInfo()
        {
            SignInPage signIn = new SignInPage(BaseTest.driver);
            signIn.SetGenderFemale(gender); /* False is to Mr. ~ True is to Mrs. */
            signIn.SetName(firstname, lastname);
            signIn.SetLogin(user_email, passwd);
            signIn.SetDateBirth(day_birth, month_birth, year_birth);
            signIn.SetNewsletter(true);
        }

        [Test, Order(5)]
        public void SetNewClientAddressInfo()
        {
            SignInPage signIn = new SignInPage(BaseTest.driver);
            signIn.SetAddress(street, city, state);
            signIn.SetCountry(zip, country_id);
            signIn.SetMobile(mobile);
            signIn.ConfirmNewUser();
        }

        [Test, Order(6)]
        public void ValidateUserAddress()
        {
            AddressPage addressUser = new AddressPage(BaseTest.driver);
            Assert.AreEqual(addressUser.GetStreet(), street);
            Assert.AreEqual(addressUser.GetCityState(), city + ", " + state + " " + zip);
            Assert.AreEqual(addressUser.GetCountry(), country_name);
            addressUser.ProceedCheckout();
        }

        [Test, Order(7)]
        public void SetTermsOfService()
        {
            ShippingPage opt = new ShippingPage(BaseTest.driver);
            opt.EnableTermsService(true);
            opt.ProceedCheckout();
        }

        [Test, Order(8)]
        public void SetPayment()
        {
            PaymentPage pay = new PaymentPage(BaseTest.driver);
            Assert.AreEqual(pay.GetTotalPrice(), total_price);
            pay.PayByBankWire();
            pay.ConfirmOrder();
            Assert.AreEqual(pay.FindPaymentSuccess(), "Your order on My Store is complete.");
        }
    }
}
