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
    public class FindingResultPage : PageObject
    {        
        [FindsBy(How = How.XPath, Using = "//*[@id='headerFilm']/h1")]
        IWebElement HeaderFilm { get; set; }

        public string GetResultOfFoundFilm()
        {
            return HeaderFilm.Text;
        }
    }
}
