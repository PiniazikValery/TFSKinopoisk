using Kinopoisk.TestFramework.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Kinopoisk.TestFramework.PageObjects
{
    public class PageObject
    {
        List<IWebElement> WebElementsContainer = new List<IWebElement>();

        public Driver driver { private get; set; }

        public void InitWebelements(Driver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver.GetDriver, this);
            var bindingFlags = BindingFlags.Instance |
                   BindingFlags.NonPublic |
                   BindingFlags.Public;
            foreach (var field in GetType().GetFields(bindingFlags).Where(fieldType => fieldType.FieldType == typeof(IWebElement)))
            {
                WebElementsContainer.Add((IWebElement)field.GetValue(this));
            }
        }

        bool PageIsLoaded()
        {
            bool result = true;
            foreach (var element in WebElementsContainer)
            {
                if (!element.Enabled)
                {
                    result = false;
                }
            }
            return result;
        }

        public void WaitPageLoading()
        {
            WebDriverWait wait = new WebDriverWait(driver.GetDriver, TimeSpan.FromSeconds(10));
            Func<IWebDriver, bool> waitForPage = new Func<IWebDriver, bool>((IWebDriver Web) =>
            {
                return PageIsLoaded();
            });
            wait.Until(waitForPage);
        }
    }
}
