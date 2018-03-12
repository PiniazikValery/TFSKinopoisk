using Kinopoisk.Test.PageObjects;
using Kinopoisk.TestFramework.Steps;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinopoisk.Test.Steps
{
    public class StartPageSteps : BaseSteps
    {
        public StartPage page { get; set; }

        public void SearchFilm()
        {
            page.SendKeysToSearchLine();
            page.ClickSearchButton();           
        }        
    }
}
