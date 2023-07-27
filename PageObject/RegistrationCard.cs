using Aquality.Selenium.Browsers;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace L2Task1.PageObject
{
    internal class RegistrationCard:Form
    { 
        private Browser _browser;
        Random random = new Random();
        public RegistrationCard() : base(By.XPath("//a[@class='login-form__terms-conditions']"), "Registration card")
        {
           
        }

        
        private ITextBox yourmailInput => ElementFactory.GetTextBox(By.XPath("//input[@placeholder='Your email']"), "Email input");
        private IComboBox dropdownField => ElementFactory.GetComboBox(By.XPath("//div[@class='dropdown__field' and text()='other']"), "Dropfield choice");
        private IComboBox dropdownOrg => ElementFactory.GetComboBox(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[4]/div/div[1]/div/div[3]/form/div[1]/div[3]/div[4]/div/div[2]/div[2]"), "Выбор orgfield");
        private ITextBox domenInput => ElementFactory.GetTextBox(By.XPath("//input[@placeholder='Domain']"), "Domen input");
        private ITextBox passwordInput => ElementFactory.GetTextBox(By.XPath("//input[@placeholder='Choose Password']"), "Password input");
        private ICheckBox Terms_and_Conditions => ElementFactory.GetCheckBox(By.XPath("//span[@class='icon icon-check checkbox__check']"), "I do accept the Terms & Conditions");
        private ILink Next_link => ElementFactory.GetLink(By.XPath("//a[@class='button--secondary']"), "Go to PhotoAndHobbiesCard");

        private string _password => "ABCDEFПghзщвавав" + random.Next(1000, 9999);
        private string _mail => "ABCDEFgh" + random.Next(1000, 9999);
        private string _domen = "yandex";
       

        public void LoginMethod()
        {
            passwordInput.ClearAndType(_password);
            yourmailInput.ClearAndType(_mail);
            domenInput.ClearAndType(_domen);
            dropdownField.Click();
            var dropdownFields = ElementFactory.FindElements<ICheckBox>(By.XPath("//div[@class='dropdown__list-item']"));
            var dropdownIndex = random.Next(dropdownFields.Count);
            ICheckBox dropdown = (ICheckBox)dropdownFields[dropdownIndex];
            dropdown.Click();
            Terms_and_Conditions.Click();
            Next_link.State.WaitForEnabled();
            Next_link.Click();

        }


        

    }
}
