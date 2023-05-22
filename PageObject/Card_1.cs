using Aquality.Selenium.Browsers;
using Aquality.Selenium.Elements;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace L2Task1.PageObject
{
    internal class Card_1:Form
    {
        public Card_1() : base(By.XPath("//a[@class=\"login-form__terms-conditions\"]"), "Карточка 1")
        {

        }

        public ITextBox Card_first => AqualityServices.Get<IElementFactory>().GetTextBox(By.XPath("//a[@class=\"login-form__terms-conditions\"]"), "Карточка 1");
        public ITextBox yourmailInput => AqualityServices.Get<IElementFactory>().GetTextBox(By.XPath("//input[@placeholder=\"Your email\"]"), "Поле для ввода емейла");
        public IComboBox dropdownField => AqualityServices.Get<IElementFactory>().GetComboBox(By.XPath("//div[@class=\"dropdown__field\" and text()=\"other\"]"), "Выбор dropfield");
        public IComboBox dropdownOrg => AqualityServices.Get<IElementFactory>().GetComboBox(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[4]/div/div[1]/div/div[3]/form/div[1]/div[3]/div[4]/div/div[2]/div[2]"), "Выбор orgfield");
        public ITextBox domenInput => AqualityServices.Get<IElementFactory>().GetTextBox(By.XPath("//input[@placeholder=\"Domain\"]"), "Поле для ввода домена");
        public ITextBox passwordInput => AqualityServices.Get<IElementFactory>().GetTextBox(By.XPath("//input[@placeholder=\"Choose Password\"]"), "Поле для ввода пароля");
        public CheckBox Terms_and_Conditions => (CheckBox)AqualityServices.Get<IElementFactory>().GetCheckBox(By.XPath("//span[@class=\"icon icon-check checkbox__check\"]"), "I do accept the Terms & Conditions");
        public ILink Next_link => AqualityServices.Get<IElementFactory>().GetLink(By.XPath("//a[@class=\"button--secondary\"]"), "Переход к карточке 2");
        public string _password;
        public string _mail;
        public string _domen;
        public Browser browser;
    }
}
