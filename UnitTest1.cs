using Aquality.Selenium.Browsers;
using L2Task1.PageObject;
using Newtonsoft.Json.Linq;
using WindowsInput;
using WindowsInput.Native;





namespace L2Task1
{

    public class Tests
    {
        
       private Browser browser;
       private JObject _testData;
       private JObject _config;
       private string _password;
       private string _mail;
       private string _domen;
       private Home_Page _home_page = new Home_Page();
       private Card_1 _card_1 = new Card_1();
       private Card_2 _card_2 = new Card_2();
       private Card_3 _card_3 = new Card_3();
       private Cookie_form _cookie_form = new Cookie_form();
       private Help_panel _help_panel = new Help_panel();
       InputSimulator inputSimulator = new InputSimulator();
       private IDataManager dataManager;
       


        [SetUp]
        public void Setup()
        {
            dataManager = new DataManager();
            _testData = dataManager.ReadTestData();
            _config = dataManager.ReadConfig();
            browser = AqualityServices.Browser;
            browser.Maximize();
            string baseUrl = _config["baseUrl"].ToString();
            browser.GoTo(baseUrl);
            browser.WaitForPageToLoad();
            Random random = new Random();
            _password = "ABCDEFПghзщвавав" + random.Next(1000, 9999);
            _mail = "ABCDEFgh" + random.Next(1000, 9999);
            _domen = "yandex";
            
        }

        

        [Test]

        public void Test1()
        {   
            Assert.IsTrue(_home_page.UI_logo.State.WaitForDisplayed(), "Домашняя страница не открыта");            
            _home_page.Start_link.Click();
            Assert.IsTrue(_card_1.State.WaitForDisplayed(), "Карточка 1 не открыта");
            _card_1.passwordInput.ClearAndType(_password);
            _card_1.yourmailInput.ClearAndType(_mail);
            _card_1.domenInput.ClearAndType(_domen);
            _card_1.dropdownField.Click();
            _card_1.dropdownOrg.Click();
            _card_1.Terms_and_Conditions.Click();
            Thread.Sleep(2000);
            _card_1.Next_link.Click();  
            Assert.IsTrue(_card_2.State.WaitForDisplayed(), "Карточка 2 не открыта");
            _card_2 .UnselectAll.Click();
            _card_2. Cables.Click();
            _card_2 .Purple.Click();
            _card_2 .Tires.Click();
            _card_2.UploadPhoto.Click();
            System.Threading.Thread.Sleep(1000);
            string filePath = _testData["filePath"].ToString();
            inputSimulator.Keyboard.TextEntry(filePath);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            System.Threading.Thread.Sleep(1000);
            _card_2.Next_link_2.Click();
            Assert.IsTrue(_card_3.State.WaitForDisplayed(), "Карточка 3 не открыта");



        }
        [Test]
        public void Test2()
        {
          
            Assert.IsTrue(_home_page.UI_logo.State.WaitForDisplayed(), "Домашняя страница не открыта");
            _home_page.Start_link.Click();
            _help_panel.Send_to_bottom.Click();
            Thread.Sleep(2000);
            Assert.IsTrue(_help_panel.Send_to_bottom.State.WaitForNotDisplayed(), "Элемент не убран");

        }

        [Test]
        public void Test3()
        {
           
            Assert.IsTrue(_home_page.UI_logo.State.WaitForDisplayed(), "Домашняя страница не открыта");
            
            _home_page.Start_link.Click();
            _cookie_form.Cookie_deny.Click();
            Assert.IsFalse(_cookie_form.Cookie_deny.State.WaitForDisplayed(), "Элемент не убран");


        }

        [Test]
        public void Test4()
        {
            
            Assert.IsTrue(_home_page.UI_logo.State.WaitForDisplayed(), "Страница не открыта");
            _home_page.Start_link.Click();
            string expectedTimeToCheck = _testData["time_to_check"].ToString();
            string currentTimeToCheck = _home_page.TimerElement.Text.Substring(0, 5);
            Assert.AreEqual(expectedTimeToCheck, currentTimeToCheck);
            

        }

        [TearDown]
        public void TeardownTest()
        {
            browser.Quit();
        }

    }
}