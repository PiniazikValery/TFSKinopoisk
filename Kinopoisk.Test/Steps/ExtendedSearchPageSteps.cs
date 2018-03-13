using Kinopoisk.Test.PageObjects;
using Kinopoisk.TestFramework.Steps;

namespace Kinopoisk.Test.Steps
{
    public class ExtendedSearchPageSteps:BaseSteps
    {
        ExtendedSearchPage page { get; set; }
      
        public void FillWantedFilmParam()
        {
            page.SendKeyToFilmNameField("Pirats");
            page.SelectFirstYearInterval("1990");
            page.SelectGenre("аниме");
            page.SelectWhatFilmSearch("сериал");
        }

        public void FillSearchByCreators()
        {
            page.SelectFirstCreator("Актер");
            page.SelectSecondCreator("Режиссер");
            page.SendKeysToFirstCreatorField("Jhony Depp");
            page.SendKeysToSecondCreatorField("Lucas");
        }
    }
}
