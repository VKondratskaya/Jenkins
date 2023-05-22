using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Elements;
using OpenQA.Selenium;
using Aquality.Selenium.Browsers;
using Aquality.Selenium.Forms;

namespace L2Task1.PageObject
{
    internal class Card_2:Form
    {
        private Browser browser;
        public Card_2() : base(By.XPath("//div[@class=\"avatar-and-interests__form\"]"), "Карточка 2")
        {

        }
        

        public ITextBox Card_second => AqualityServices.Get<IElementFactory>().GetTextBox(By.XPath("//div[@class=\"avatar-and-interests__form\"]"), "Карточка 2");
        public CheckBox UnselectAll => (CheckBox)AqualityServices.Get<IElementFactory>().GetCheckBox(By.XPath("//label[@for='interest_unselectall']"), "все галки сняты");
        public CheckBox Cables => (CheckBox)AqualityServices.Get<IElementFactory>().GetCheckBox(By.XPath("//label[@for='interest_cables']"), "cables нажали");
        public CheckBox Purple => (CheckBox)AqualityServices.Get<IElementFactory>().GetCheckBox(By.XPath("//label[@for='interest_purple']"), "purple нажали");
        public CheckBox Tires => (CheckBox)AqualityServices.Get<IElementFactory>().GetCheckBox(By.XPath("//label[@for='interest_tires']"), "tires нажали");
        public ILink Next_link_2 => AqualityServices.Get<IElementFactory>().GetLink(By.XPath("//button[contains(@class, 'button--stroked') and contains(@class, 'button--white') and contains(@class, 'button--fluid') and contains(text(), 'Next')]"), "Переход к карточке 3");
        public ILink UploadPhoto => AqualityServices.Get<IElementFactory>().GetLink(By.XPath("//a[@class='avatar-and-interests__upload-button']"), "Кнопка загрузки фото");
        public ILink fileInput = AqualityServices.Get<IElementFactory>().GetLink(By.XPath("//div[@class='avatar-and-interests__avatar-image']"), "Форма загрузки файла");

        
    }
}
