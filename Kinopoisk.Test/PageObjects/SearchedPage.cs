using Kinopoisk.TestFramework.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinopoisk.Test.PageObjects
{
    public class SearchedPage : PageObject
    {      

        [FindsBy(How = How.LinkText, Using = "Пираты Карибского моря: Проклятие Черной жемчужины")]
        IWebElement TargetLink { get;  set; }

        public void ClickOnTargetLink()
        {
            TargetLink.Click();
            var resultToAssert = new FindingResultPage();
            Assert.IsTrue("Пираты Карибского моря: Проклятие Черной жемчужины" == resultToAssert.GetResultOfFoundFilm());
        }
    }
}
