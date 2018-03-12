using Kinopoisk.TestFramework.Drivers;
using Kinopoisk.TestFramework.PageObjects;
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
        public string PageName { get; private set; }

        public Driver driver;

        object LocalPage;

        public void InitPageObjects()
        {
            var bindingFlags = BindingFlags.Instance |
                   BindingFlags.NonPublic |
                   BindingFlags.Public;
            var test = GetType().GetFields(bindingFlags).Where(field => field.FieldType.IsSubclassOf(typeof(PageObject))).Count();
            if (GetType().GetFields(bindingFlags).Where(field => field.FieldType.IsSubclassOf(typeof(PageObject))).Count() > 1)
            {
                throw new Exception("Steps must have only one PageObject");
            }
            foreach (var field in GetType().GetFields(bindingFlags))
            {
                if (field.FieldType.IsSubclassOf(typeof(PageObject)))
                {
                    field.SetValue(this, Activator.CreateInstance(field.FieldType));
                    ((PageObject)field.GetValue(this)).InitWebelements(driver);
                    LocalPage = ((PageObject)field.GetValue(this));
                    PageName = field.FieldType.Name;
                    break;
                }
            }
        }
        
        public void WaitLoadingPage()
        {
            ((PageObject)LocalPage).WaitPageLoading();
        }
    }
}
