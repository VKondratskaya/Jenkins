using Aquality.Selenium.Browsers;
using L2Task1.PageObject;
using WindowsInput.Native;
using WindowsInput;
using L2Task1.Utils;
using Aquality.Selenium.Elements;
using Aquality.Selenium.Elements.Interfaces;
using System.Collections.Generic;
using AngleSharp.Text;

namespace L2Task1
{

    public class Tests
    {

        private Browser browser;
        private HomePage _homePage;
        private RegistrationCard _registrationCard = new RegistrationCard();
        private PhotoAndHobbiesCard _hobbyCard = new PhotoAndHobbiesCard();
        private FullInformationCard _fullInformationCard = new FullInformationCard();
        private Cookie_form _cookieForm = new Cookie_form();
        private HelpPanel _helpPanel = new HelpPanel();
        private InputSimulator inputSimulator = new InputSimulator();

        [SetUp]
        public void Setup()
        {

            browser = AqualityServices.Browser;
            _homePage = new HomePage();
            _registrationCard = new RegistrationCard();
            browser.Maximize();
            browser.GoTo(DataUtils.baseUrl);
        
        }



        [Test]

        public void Test1()
        {
            Assert.IsTrue(_homePage.HomePageOpen(), "Home Page isn't open");
            _homePage.StartLinkClick();
            Assert.IsTrue(_registrationCard.State.WaitForDisplayed(), "Card 1 isn't open");
            _registrationCard.LoginMethod();
            Assert.IsTrue(_hobbyCard.State.WaitForDisplayed(), "Card 2 isn't open");
            _hobbyCard.GetRandomCheckboxes(DataUtils.numberOfHobbies);
            _hobbyCard.SelectPhoto();
            Assert.IsTrue(_fullInformationCard.State.WaitForDisplayed(), "The Card 3 isn't open");




        }
        [Test]
        public void Test2()
        {

            Assert.IsTrue(_homePage.HomePageOpen(), "Home Page isn't open");
            _homePage.StartLinkClick();
            _helpPanel.SendToBottom.Click();
            Assert.IsTrue(_helpPanel.SendToBottom.State.WaitForNotDisplayed(), "The element isn't unselected");

        }

        [Test]
        public void Test3()
        {

            Assert.IsTrue(_homePage.HomePageOpen(), "Home Page isn't open");
            _homePage.StartLinkClick();
            _cookieForm.CookieDeny.Click();
            Assert.IsFalse(_cookieForm.CookieDeny.State.WaitForDisplayed(), "The element isn't unselected");


        }

        [Test]

        public void Test4()
        {
            Assert.IsTrue(_homePage.HomePageOpen(), "Home Page isn't open");
            Assert.IsTrue(_homePage.GetExpectedTime().StartsWith(_homePage.GetCurrentTime()));
        }

        [TearDown]
        public void TeardownTest()
        {
            browser.Quit();
        }

    }
}