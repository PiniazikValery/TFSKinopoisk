using Kinopoisk.TestFramework.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinopoisk.Test.PageObjects
{
    public class StartPage:PageObject
    {        
        [FindsBy(How = How.Name, Using = "kp_query")]
        IWebElement SearchLine { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='partial_component__header']/div/header/div/div[2]/span[2]/form/span/input[1]")]
        IWebElement SearchButton { get; set; }                        

        public void SendKeysToSearchLine()
        {
            SearchLine.SendKeys("Пираты карибского моря");
        }

        public void ClickSearchButton()
        {
            SearchButton.Click();
        }

        public void SendKeysToSearchLine(string Keys)
        {
            SearchLine.SendKeys(Keys);
        }
    }
}
