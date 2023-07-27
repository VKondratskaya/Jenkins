using Aquality.Selenium.Forms;
using Aquality.Selenium.Elements.Interfaces;
using OpenQA.Selenium;
using L2Task1.Utils;

internal class HomePage : Form
{

    public HomePage(): base(By.XPath("//div[@class='logo__icon']"),"Home Page is opened")
    {
        
    }

   
    private ITextBox UI_logo => ElementFactory.GetTextBox(By.XPath("//div[@class='logo__icon']"), "Home Page is opened");
    private ILink Start_link => ElementFactory.GetLink(By.XPath("//a[@class='start__link' and @href='/game.html']"), "Go to Registration Card");
    private ILabel TimerElement => ElementFactory.GetLabel(By.XPath("//div[@class='timer timer--white timer--center']"), "Timer starts at 00:00");

    public bool HomePageOpen() => UI_logo.State.WaitForDisplayed();

    public void StartLinkClick() 
    {
        Start_link.Click();
    }
    public string GetCurrentTime()
    {
        return TimerElement.GetText().Substring(0, 5);
    }


    public string GetExpectedTime()
    {
        return DataUtils.timeToCheck;
    }

    

}