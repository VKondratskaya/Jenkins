using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;


namespace L2Task1.PageObject
{
    internal class HelpPanel : Form
    {
      
        public HelpPanel() : base(By.XPath("//button[contains(@class, 'button--solid') and contains(@class, 'button--blue') and contains(@class, 'help-form__send-to-bottom-button')]"), "Кнопка Send to bottom button")
        {
            
        }

     public ILink SendToBottom => ElementFactory.GetLink(By.XPath("//button[contains(@class, 'button--solid') and contains(@class, 'button--blue') and contains(@class, 'help-form__send-to-bottom-button')]"), "Send to bottom button");
    }
}



            