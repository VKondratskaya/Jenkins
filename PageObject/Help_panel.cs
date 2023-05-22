using Aquality.Selenium.Browsers;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;


namespace L2Task1.PageObject
{
    internal class Help_panel : Form
    {
        private Browser browser;

        public Help_panel() : base(By.XPath("//button[contains(@class, 'button--solid') and contains(@class, 'button--blue') and contains(@class, 'help-form__send-to-bottom-button')]"), "Кнопка Send to bottom")
        {
            
        }

     public ILink Send_to_bottom => AqualityServices.Get<IElementFactory>().GetLink(By.XPath("//button[contains(@class, 'button--solid') and contains(@class, 'button--blue') and contains(@class, 'help-form__send-to-bottom-button')]"), "Кнопка Send to bottom");
    }
}



            