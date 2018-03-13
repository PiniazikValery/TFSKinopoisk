using Kinopoisk.Test.PageObjects;
using Kinopoisk.TestFramework.Steps;


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
