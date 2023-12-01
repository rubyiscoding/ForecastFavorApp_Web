using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace ForecastFavorApp_IntegrationTest
{
    [TestClass]
    public class IntegrationTest
    {
        private IWebDriver _webDriver;

        [TestInitialize]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            var opts = new ChromeOptions();
            _webDriver = new ChromeDriver(opts);
        }
        //Asserting the title
        [TestMethod]
        public void Test()
        {
            var baseUrl = "https://localhost:7293/";
            _webDriver.Navigate().GoToUrl(baseUrl);
            Assert.IsTrue(_webDriver.Title.Contains("ForecastFavorApp"), $"Expected title not found on {baseUrl}");
        }
        //Asserting the today tab title
        [TestMethod]
        public void TodayTabTest()
        {
            var baseUrl = "https://localhost:7293/";
            _webDriver.Navigate().GoToUrl(baseUrl);
            var todayTab = _webDriver.FindElement(By.CssSelector(".nav-item"));
            Assert.AreEqual("Today", todayTab.Text);
        }
        //Asserting the tomorrow tab title
        [TestMethod]
        public void TomorrowTabTest()
        {
            var baseUrl = "https://localhost:7293/";
            _webDriver.Navigate().GoToUrl(baseUrl);
            var tomorrowTab = _webDriver.FindElement(By.LinkText("Tomorrow"));
            Assert.AreEqual("Tomorrow", tomorrowTab.Text);
        }
        [TestCleanup]
        public void Teardown()
        {
            _webDriver.Quit();
            _webDriver.Dispose();

        }
    }

}