using Kinopoisk.Test.Steps;
using Kinopoisk.TestFramework.TestCases;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinopoisk.Test.TestCases
{
    [TestFixture]
    [Parallelizable]
    class SP_TC1:TestCase
    {
        StartPageSteps UserAtStartPage { get; set; }

        [Test]
        public void TestSearchMove()
        {
            UserAtStartPage.SearchFilm();           
        }
    }
}
