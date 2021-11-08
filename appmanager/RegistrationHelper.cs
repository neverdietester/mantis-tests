using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;



namespace mantis_tests
{
    public class RegistrationHelper : HelperBase
    {
        public RegistrationHelper(ApplicationManager manager) : base(manager) { }

        internal void Register(AccountData account)
        {
            OpenMainPage();
            OpenRegistationForm();
            FillRegistrationForm(account);
            SubmintRegistration();

        }

        private void OpenRegistationForm()
        {
            driver.FindElement(By.LinkText("Signup for a new account")).Click(); ;
        }

        private void SubmintRegistration()
        {
            driver.FindElement(By.XPath("//input[@value='Signup']")).Click();
        }

        private void FillRegistrationForm(AccountData account)
        {
            driver.FindElement(By.Name("username")).SendKeys(account.Name);
            driver.FindElement(By.Name("email")).SendKeys(account.Email);
        }

        private void OpenMainPage()
        {
            manager.Driver.Url = "http://localhost/mantisbt-2.25.2/login_page.php";
        }
    }
}
