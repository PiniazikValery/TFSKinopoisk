using Kinopoisk.TestFramework.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinopoisk.Test.PageObjects
{
    public class ExtendedSearchPage : PageObject
    {       
        //Search Film Form
        [FindsBy(How = How.XPath, Using = "//*[@name='m_act[find]' and @id='find_film']")]
        IWebElement FilmName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@name='m_act[year]' and @id='year']")]
        IWebElement FilmYear { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@name='m_act[actor]']")]
        IWebElement Actor { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@name='m_act[cast]']")]
        IWebElement Creators { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='from_year']")]
        IWebElement FirstYearInterval { get; set; }

        SelectElement FirstYearIntervalDropDown
        {
            get { return new SelectElement(FirstYearInterval); }
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='to_year']")]
        IWebElement LastYearInterval { get; set; }

        SelectElement LastYearIntervalDropDown
        {
            get { return new SelectElement(LastYearInterval); }
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='country']")]
        IWebElement Country { get; set; }

        SelectElement CountryDropDown
        {
            get { return new SelectElement(Country); }
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='company']")]
        IWebElement Distributor { get; set; }

        SelectElement DistributorDropDown
        {
            get { return new SelectElement(Distributor); }
        }

        [FindsBy(How = How.XPath, Using = "//*[@name='m_act[mpaa]']")]
        IWebElement MPAA { get; set; }

        SelectElement MPAADropDown
        {
            get { return new SelectElement(MPAA); }
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='m_act[genre]']")]
        IWebElement Genre { get; set; }

        SelectElement GenreDropDown
        {
            get { return new SelectElement(Genre); }
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='prem_month']")]
        IWebElement PremMounth { get; set; }

        SelectElement PremMounthDropDown
        {
            get { return new SelectElement(PremMounth); }
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='prem_year']")]
        IWebElement PremYear { get; set; }

        SelectElement PremYearDropDown
        {
            get { return new SelectElement(PremYear); }
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='prem_type']")]
        IWebElement PremType { get; set; }

        SelectElement PremTypeDropDown
        {
            get { return new SelectElement(PremType); }
        }

        [FindsBy(How = How.Name, Using = "m_act[box_vector]")]
        IWebElement SborsSelect { get; set; }

        SelectElement SborsSelectDropDown
        {
            get { return new SelectElement(SborsSelect); }
        }

        [FindsBy(How = How.Name, Using = "m_act[box]")]
        IWebElement SborsValue { get; set; }

        [FindsBy(How = How.Name, Using = "m_act[box_type]")]
        IWebElement SborsType { get; set; }

        SelectElement SborsTypeDropDown
        {
            get { return new SelectElement(SborsType); }
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='formSearchMain']//*[@name='m_act[content_find]']")]
        IWebElement WhatFilmSearch { get; set; }

        SelectElement WhatFilmSearchDropDown
        {
            get { return new SelectElement(WhatFilmSearch); }
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='formSearchMain']//*[@class='el_18 submit nice_button']")]
        IWebElement SearchFilmButton { get; set; }

        public void SendKeyToFilmNameField(string keys)
        {
            FilmName.SendKeys(keys);
        }

        public void SendKeysToFilmYearField(string keys)
        {
            FilmYear.SendKeys(keys);
        }
        public void SendKeysToActorField(string keys)
        {
            Actor.SendKeys(keys);
        }
        public void SendKeysToCreatorsField(string keys)
        {
            Creators.SendKeys(keys);
        }
        public void SendKeysToSborsValueField(string keys)
        {
            SborsValue.SendKeys(keys);
        }
        public void SelectFirstYearInterval(string text)
        {
            FirstYearIntervalDropDown.SelectByText(text);
        }
        public void SelectLastYearInterval(string text)
        {
            LastYearIntervalDropDown.SelectByText(text);
        }
        public void SelectCountry(string text)
        {
            CountryDropDown.SelectByText(text);
        }
        public void SelectDistributor(string text)
        {
            DistributorDropDown.SelectByText(text);
        }
        public void SelectMPAA(string text)
        {
            MPAADropDown.SelectByText(text);
        }
        public void SelectGenre(string text)
        {
            GenreDropDown.SelectByText(text);
        }
        public void SelectPremMounth(string text)
        {
            PremMounthDropDown.SelectByText(text);
        }
        public void SelectPremYear(string text)
        {
            PremYearDropDown.SelectByText(text);
        }
        public void SelectPremType(string text)
        {
            PremTypeDropDown.SelectByText(text);
        }
        public void SelectSborsSelect(string text)
        {
            SborsSelectDropDown.SelectByText(text);
        }
        public void SelectSborsType(string text)
        {
            SborsTypeDropDown.SelectByText(text);
        }
        public void SelectWhatFilmSearch(string text)
        {
            WhatFilmSearchDropDown.SelectByText(text);
        }
        public void ClickSearchFilmButton()
        {
            SearchFilmButton.Click();
        }
        //Search by creators form
        [FindsBy(How = How.Id, Using = "btn_search_6")]
        IWebElement SearchByCreatorsButton { get; set; }

        [FindsBy(How = How.Id, Using = "cr_search_field_1_select")]
        IWebElement FirstCreator { get; set; }
        SelectElement FirstCreatorDropDown
        {
            get { return new SelectElement(FirstCreator); }
        }

        [FindsBy(How = How.Id, Using = "cr_search_field_2_select")]
        IWebElement SecondCreator { get; set; }
        SelectElement SecondCreatorDropDown
        {
            get { return new SelectElement(SecondCreator); }
        }

        [FindsBy(How = How.Id, Using = "cr_search_field_1")]
        IWebElement FirstCreatorField { get; set; }

        [FindsBy(How = How.Id, Using = "cr_search_field_2")]
        IWebElement SecondCreatorField { get; set; }

        public void SelectFirstCreator(string text)
        {
            FirstCreatorDropDown.SelectByText(text);
        }
        public void SelectSecondCreator(string text)
        {
            SecondCreatorDropDown.SelectByText(text);
        }
        public void SendKeysToFirstCreatorField(string keys)
        {
            FirstCreatorField.SendKeys(keys);
        }
        public void SendKeysToSecondCreatorField(string keys)
        {
            SecondCreatorField.SendKeys(keys);
        }
    }
}
