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
        [TestMethod]
        public void Test()
        {
            var baseUrl = "https://localhost:7293/";
            _webDriver.Navigate().GoToUrl(baseUrl);
            Assert.IsTrue(_webDriver.Title.Contains("ForecastFavorApp"), $"Expected title not found on {baseUrl}");
        }
        [TestCleanup]
        public void Teardown()
        {
            _webDriver.Quit();
            _webDriver.Dispose();

        }
    }

}