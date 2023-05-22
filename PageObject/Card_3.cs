using Aquality.Selenium.Browsers;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace L2Task1.PageObject
{
    internal class Card_3:Form
    {
        private Browser browser;
        public Card_3() : base(By.XPath("//div[contains(@class, 'personal-details__td-label') and text() = 'First name']"), "Карточка 3")
        {
            
        }
        public ITextBox Card_third => AqualityServices.Get<IElementFactory>().GetTextBox(By.XPath("//div[contains(@class, 'personal-details__td-label') and text() = 'First name']"), "Карточка 3");
    }
}


