using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;

namespace Kinopoisk.TestFramework.Drivers
{
    public class Driver:IBrowserFactory
    {
        public Driver(WebBrowsers browser, string startPage)
        {
            this.browser = browser;
            this.startPage = startPage;
            InitBrowser(browser);
            LoadApplication(startPage);
        }

        private WebBrowsers browser;

        private string startPage;

        private Guid driverKey;

        private static readonly IDictionary<Guid, IWebDriver> Drivers = new Dictionary<Guid, IWebDriver>();

        public IWebDriver GetDriver
        {
            get
            {
                if (Drivers[driverKey] == null)
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method InitBrowser.");
                return Drivers[driverKey];
            }
            set
            {
                GetDriver = value;
            }
        }

        public void LoadApplication(string url)
        {
            GetDriver.Url = url;
        }

        public void InitBrowser(WebBrowsers browserName)
        {
            switch (browserName)
            {
                case WebBrowsers.Firefox:
                    driverKey = Guid.NewGuid();
                    Drivers.Add(driverKey, new FirefoxDriver());
                    break;
                case WebBrowsers.InternetExplorer:
                    driverKey = Guid.NewGuid();
                    Drivers.Add(driverKey, new InternetExplorerDriver());
                    break;
                case WebBrowsers.Chrome:
                    driverKey = Guid.NewGuid();
                    Drivers.Add(driverKey, new ChromeDriver());
                    break;
                default:
                    driverKey = Guid.NewGuid();
                    Drivers.Add(driverKey, new ChromeDriver());
                    break;
            }
        }

        public void CloseAllDrivers()
        {
            foreach (var key in Drivers.Keys)
            {
                Drivers[key].Close();
                Drivers[key].Quit();
            }
            Drivers.Clear();
        }

        public void CloseDriver()
        {
            GetDriver.Close();
            GetDriver.Quit();
            Drivers.Remove(driverKey);
        }
    }
    public enum WebBrowsers
    {
        InternetExplorer,
        Firefox,
        Chrome
    }
}
