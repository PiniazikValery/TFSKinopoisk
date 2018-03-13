using Kinopoisk.TestFramework.Drivers;
using Kinopoisk.TestFramework.StaticConstants;
using Kinopoisk.TestFramework.Steps;
using NUnit.Framework;
using System;
using System.Linq;
using System.Reflection;

namespace Kinopoisk.TestFramework.TestCases
{
    [TestFixture]
    public class TestCase
    {        
        public Driver driver = new Driver(WebBrowsers.Chrome);

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
            var testCaseFields = GetType().GetFields(FrameworkConstants.BindingFlags).Where(field=>field.FieldType.IsSubclassOf(FrameworkConstants.BaseStepsType));
            foreach (var field in testCaseFields)
            {
                field.SetValue(this, Activator.CreateInstance(field.FieldType));
                ((BaseSteps)field.GetValue(this)).InitPageObjects(driver);                
            }
        }
    }
}
