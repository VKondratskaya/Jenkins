using Aquality.Selenium.Browsers;
using Aquality.Selenium.Forms;
using Aquality.Selenium.Elements.Interfaces;
using OpenQA.Selenium;

internal class Home_Page : Form
{
    private Browser browser;

    public Home_Page(): base(By.XPath("//div[@class='logo__icon']"),"Домашняя страница")
    {
        
    }

   
    public ITextBox UI_logo => AqualityServices.Get<IElementFactory>().GetTextBox(By.XPath("//div[@class='logo__icon']"), "Домашняя страница открыта");
    public ILink Start_link => AqualityServices.Get<IElementFactory>().GetLink(By.XPath("//a[@class='start__link' and @href='/game.html']"), "Переход на страницу с авторизацией");
    public ILabel TimerElement => AqualityServices.Get<IElementFactory>().GetLabel(By.XPath("//div[@class='timer timer--white timer--center']"), "Таймер стоит на нуле");

    }