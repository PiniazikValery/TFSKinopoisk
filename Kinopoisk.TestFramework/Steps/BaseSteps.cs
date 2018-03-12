using Kinopoisk.TestFramework.Drivers;
using Kinopoisk.TestFramework.PageObjects;
using Kinopoisk.TestFramework.StaticConstants;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Kinopoisk.TestFramework.Steps
{
    public abstract class BaseSteps
    {        
        public PageObject WorkPage;

        public void InitPageObjects(Driver driver)
        {           
            var pageObjects = GetType().GetFields(FrameworkConstants.BindingFlags).Where(field => field.FieldType.IsSubclassOf(typeof(PageObject)));
            if (pageObjects.Count() > 1)
            {
                throw new Exception("Steps must have only one PageObject");
            }
            foreach (var field in pageObjects)
            {
                field.SetValue(this, Activator.CreateInstance(field.FieldType));
                WorkPage = (PageObject)field.GetValue(this);
                WorkPage.InitWebelements(driver);                                
                break;
            }
        }        
    }
}
