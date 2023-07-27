using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace L2Task1.PageObject
{
    internal class FullInformationCard : Form
    {

        public FullInformationCard() : base(By.XPath("//div[contains(@class, 'personal-details__td-label') and text() = 'First name']"), "FullInformationCard")
        {
              
        }
        
    }

}


