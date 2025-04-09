using NUnit.Framework;
using OpenQA.Selenium;

namespace SpecFlowProject.PageObjects
{
    public class LoginPage : BasePage
    {
        #region WebElements

        private IWebElement UsernameField => Driver.FindElement(By.Id("userName"));

        private IWebElement FirstnameField => Driver.FindElement(By.Id("firstname"));

        private IWebElement LastnameField => Driver.FindElement(By.Id("lastname"));

        //private IWebElement RecaptchaCheckBox => Driver.FindElement(By.XPath("//*[@id=\"recaptcha-anchor\"]/div[2]"));

        private IWebElement RegisterButton => Driver.FindElement(By.Id("register"));

        private IWebElement PasswordField => Driver.FindElement(By.Id("password"));

        private IWebElement ErrorMessage => Driver.FindElement(By.Id("name"));

        private IWebElement LoginButton => Driver.FindElement(By.Id("login"));

        private IWebElement NewUserButton => Driver.FindElement(By.Id("newUser"));

        private IWebElement BackToLoginButton => Driver.FindElement(By.Id("gotologin"));

        #endregion

        public void NewUser(string firstname, string lastname, string username, string password)
        {
            FirstnameField.SendKeys(firstname);
            LastnameField.SendKeys(lastname);
            UsernameField.SendKeys(username);
            PasswordField.SendKeys(password);

            IWebElement recaptchaFrame = Driver.FindElement(By.XPath("//iframe[@title='reCAPTCHA']"));
            Driver.SwitchTo().Frame(recaptchaFrame);
            IWebElement recaptchaCheckbox = Driver.FindElement(By.Id("recaptcha-anchor"));
            recaptchaCheckbox.Click();
            Driver.SwitchTo().DefaultContent();

            RegisterButton.Click();
        }

        public void FillNewUserData(string firstname, string lastname, string username, string password)
        {
            FirstnameField.SendKeys(firstname);
            LastnameField.SendKeys(lastname);
            UsernameField.SendKeys(username);
            PasswordField.SendKeys(password);
        }

        public void EnterUsername(string username)
        {
            UsernameField.SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            PasswordField.SendKeys(password);
        }

        public void VerifyMessage(string message)
        {
            Assert.IsTrue(ErrorMessage.Text.Equals(message));
        }


        public void VerifyRequiredField(IWebElement field)
        {
            Assert.IsTrue(field.GetAttribute("class").Contains("is-invalid"));
        }

        public void VerifyRequiredFields(params IWebElement[] fields)
        {
            foreach (var field in fields)
            {
                VerifyRequiredField(field);
            }
        }

        public void VerifyRequiredFields()
        {
            VerifyRequiredFields(UsernameField, PasswordField);
        }

        public void VerifyUserNameRequiredField()
        {
            VerifyRequiredFields(UsernameField);
        }

        public void VerifyPasswordRequiredField()
        {
            VerifyRequiredFields(PasswordField);
        }


        public void ClickLoginButton()
        {
            LoginButton.Click();
        }

        public void ClickRecaptchaCheckBox()
        {

            IWebElement recaptchaFrame = Driver.FindElement(By.XPath("//iframe[@title='reCAPTCHA']"));
            Driver.SwitchTo().Frame(recaptchaFrame);
            IWebElement recaptchaCheckbox = Driver.FindElement(By.Id("recaptcha-anchor"));
            recaptchaCheckbox.Click();
            Driver.SwitchTo().DefaultContent();

        }

        public void ClickRegisterButton()
        {
            RegisterButton.Click();
        }

        public void ClickNewUserButton()
        {
            NewUserButton.Click();
        }

        public void ClickBackToLoginButton()
        {
            BackToLoginButton.Click();
        }

        public bool IsWelcomeMessageDisplayed()
        {
            return Driver.FindElement(By.Id("welcomeMessage")).Displayed;
        }

        public bool IsDashboardUrl()
        {
            return Driver.Url.Contains("dashboard");
        }
    }
}
