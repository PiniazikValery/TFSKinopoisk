using Kinopoisk.TestFramework.Drivers;
using Kinopoisk.TestFramework.Steps;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Kinopoisk.TestFramework.TestCases
{
    [TestFixture]
    public class TestCase
    {
        public Driver driver = new Driver(WebBrowsers.Chrome, "https://www.kinopoisk.ru/");
        [OneTimeSetUp]
        public void BeforeAllTests()
        {                    
            InitSteps();
        }
        [OneTimeTearDown]
        public void AfterAllTests()
        {
            driver.CloseDriver();
        }
        private void InitSteps()
        {
            var bindingFlags = BindingFlags.Instance |
                 BindingFlags.NonPublic |
                 BindingFlags.Public;
            var testCaseFields = GetType().GetFields(bindingFlags);
            foreach (var field in testCaseFields)
            {
                if (field.FieldType.IsSubclassOf(typeof(BaseSteps)))
                {                    
                    field.SetValue(this, Activator.CreateInstance(field.FieldType));
                    ((BaseSteps)field.GetValue(this)).driver = driver;
                    ((BaseSteps)field.GetValue(this)).InitPageObjects();
                }
            }
        }
    }
}
