using Aquality.Selenium.Browsers;
using Aquality.Selenium.Forms;
using Aquality.Selenium.Elements.Interfaces;
using OpenQA.Selenium;

namespace L2Task1.PageObject
{
    internal class Cookie_form:Form
    {
        private Browser browser;


       
            public Cookie_form() : base(By.XPath("//button[contains(@class, 'button--solid') and contains(@class, 'button--transparent')]"), "Delete cookie")
            {

            }

        public ILink CookieDeny => ElementFactory.GetLink(By.XPath("//button[contains(@class, 'button--solid') and contains(@class, 'button--transparent')]"), "Delete cookie");
    }
}
