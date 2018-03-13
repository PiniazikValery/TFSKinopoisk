using Kinopoisk.Test.Steps;
using Kinopoisk.TestFramework.TestCases;
using NUnit.Framework;

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
