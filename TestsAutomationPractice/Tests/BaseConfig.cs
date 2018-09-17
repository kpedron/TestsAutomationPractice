using System;
using System.Configuration;

namespace TestsAutomationPractice
{
    public abstract class BaseConfig
    {
        protected string user_email { get; }
        protected string wrong_passwd { get; }
        protected string passwd { get; }
        protected string firstname { get; }
        protected string lastname { get; }
        protected string product_id { get; }
        protected string product_price { get; }
        protected string total_price { get; }
        protected string gender { get; }
        protected string day_birth { get; }
        protected string month_birth { get; }
        protected string year_birth { get; }
        protected string street { get; }
        protected string city { get; }
        protected string state { get; }
        protected string zip { get; }
        protected string country_id { get; }
        protected string country_name { get; }
        protected string mobile { get; }

        public BaseConfig()
        {
            user_email = ConfigurationManager.AppSettings["user_email"];
            wrong_passwd = ConfigurationManager.AppSettings["wrong_passwd"];
            passwd = ConfigurationManager.AppSettings["passwd"];
            firstname = ConfigurationManager.AppSettings["firstname"];
            lastname = ConfigurationManager.AppSettings["lastname"];
            product_id = ConfigurationManager.AppSettings["product_id"];
            product_price = ConfigurationManager.AppSettings["product_price"];
            total_price = ConfigurationManager.AppSettings["total_price"];
            gender = ConfigurationManager.AppSettings["gender"];
            day_birth = ConfigurationManager.AppSettings["day_birth"];
            month_birth = ConfigurationManager.AppSettings["month_birth"];
            year_birth = ConfigurationManager.AppSettings["year_birth"];
            street = ConfigurationManager.AppSettings["street"];
            city = ConfigurationManager.AppSettings["city"];
            state = ConfigurationManager.AppSettings["state"];
            zip = ConfigurationManager.AppSettings["zip"];
            country_id  = ConfigurationManager.AppSettings["country_id"];
            country_name = ConfigurationManager.AppSettings["country_name"];
            mobile = ConfigurationManager.AppSettings["mobile"];
        }
    }
}
