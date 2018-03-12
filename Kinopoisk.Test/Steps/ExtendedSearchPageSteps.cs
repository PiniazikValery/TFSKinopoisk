using Kinopoisk.Test.PageObjects;
using Kinopoisk.TestFramework.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kinopoisk.TestFramework.Filters;

namespace Kinopoisk.Test.Steps
{
    public class ExtendedSearchPageSteps:BaseSteps
    {
        ExtendedSearchPage page { get; set; }

        [Step]
        public void FillWantedFilmParam()
        {
            page.SendKeyToFilmNameField("Pirats");
            page.SelectFirstYearInterval("1990");
            page.SelectGenre("аниме");
            page.SelectWhatFilmSearch("сериал");
        }

        [Step]
        public void FillSearchByCreators()
        {
            page.SelectFirstCreator("Актер");
            page.SelectSecondCreator("Режиссер");
            page.SendKeysToFirstCreatorField("Jhony Depp");
            page.SendKeysToSecondCreatorField("Lucas");
        }
    }
}
