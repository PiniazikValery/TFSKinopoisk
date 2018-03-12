using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinopoisk.TestFramework.Drivers
{
    public interface IDriver
    {
        void InitBrowser(WebBrowsers browser);
        IWebDriver GetDriver { get; set; }
        void GoToUrl(string url);
        void CloseDriver();
        void CloseAllDrivers();
    }
}
