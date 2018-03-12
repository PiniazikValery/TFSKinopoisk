using Kinopoisk.Test.PageObjects;
using Kinopoisk.TestFramework.Filters;
using Kinopoisk.TestFramework.Steps;


namespace Kinopoisk.Test.Steps
{
    public class StartPageSteps : BaseSteps
    {
        public StartPage page { get; set; }

        [Step]
        public void SearchFilm()
        {
            page.SendKeysToSearchLine();
            page.ClickSearchButton();           
        }

        [Step]
        public void ClickLoginButton()
        {
            page.ClickLogin();
        }
    }
}
