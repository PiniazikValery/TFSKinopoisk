using Kinopoisk.TestFramework.Drivers;
using Kinopoisk.TestFramework.StaticConstants;
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
    public abstract class PageObject
    {
        List<IWebElement> WebElementsContainer = new List<IWebElement>();

        public Driver driver { get; set; }

        public void InitWebelements(Driver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver.GetDriver, this);            
            foreach (var field in GetType().GetFields(FrameworkConstants.BindingFlags).Where(fieldType => fieldType.FieldType.IsInstanceOfType(FrameworkConstants.WebElementType)))
            {
                WebElementsContainer.Add((IWebElement)field.GetValue(this));
            }
        }        

        public void WaitPageLoading()
        {            
            DefaultWait<List<IWebElement>> wait = new DefaultWait<List<IWebElement>>(WebElementsContainer);
            wait.Timeout = TimeSpan.FromMinutes(5);
            wait.PollingInterval = TimeSpan.FromMilliseconds(250);
            Func<List<IWebElement>, bool> PageIsLoaded = new Func<List<IWebElement>, bool>((List<IWebElement> webElementsContainer) =>
            {
                bool result = true;
                foreach (var element in webElementsContainer)
                {
                    if (!element.Enabled)
                    {
                        result = false;
                    }
                }
                return result;
            });
            wait.Until(PageIsLoaded);
        }
    }
}
