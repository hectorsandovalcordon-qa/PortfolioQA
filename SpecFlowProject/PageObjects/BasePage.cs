using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject.PageObjects
{
    public class BasePage
    {
        protected readonly IWebDriver Driver;

        private const string _baseUrl = "https://demoqa.com/";

        public BasePage()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
        }
        public void Open(string parameter)
        {
            Driver.Navigate().GoToUrlAsync(_baseUrl + parameter);
        }
    }
}
