using Aquality.Selenium.Browsers;
using Aquality.Selenium.Forms;
using Aquality.Selenium.Elements.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2Task1.PageObject
{
    internal class Cookie_form:Form
    {
        private Browser browser;


       
            public Cookie_form() : base(By.XPath("//button[contains(@class, 'button--solid') and contains(@class, 'button--transparent')]"), "Убрать cookie")
            {

            }

        public ILink Cookie_deny => AqualityServices.Get<IElementFactory>().GetLink(By.XPath("//button[contains(@class, 'button--solid') and contains(@class, 'button--transparent')]"), "Убрать cookie");
    }
}
