using Aquality.Selenium.Elements.Interfaces;
using OpenQA.Selenium;
using Aquality.Selenium.Forms;
using WindowsInput.Native;
using WindowsInput;

using L2Task1.Utils;


namespace L2Task1.PageObject
{
    internal class PhotoAndHobbiesCard : Form
    {
        InputSimulator inputSimulator = new InputSimulator();



        public PhotoAndHobbiesCard() : base(By.XPath("//div[@class='avatar-and-interests__form']"), "PhotoAndHobbiesCard")
        {

        }

        public ICheckBox UnselectAll => ElementFactory.GetCheckBox(By.XPath("//label[@for='interest_unselectall']"), "All choices are unselectrd");
        private IButton NextLink2 => ElementFactory.GetButton(By.XPath("//button[@name='button' and contains(@class, 'button--stroked') and contains(@class, 'button--white') and contains(@class, 'button--fluid')]"), "Go to FullInformationCard");

        private IList<ICheckBox> AllCheckboxes => FormElement.FindChildElements<ICheckBox>(By.XPath("//label[not (contains(@for,'select'))]"));

        public ILink UploadPhoto => ElementFactory.GetLink(By.XPath("//a[@class='avatar-and-interests__upload-button']"), "Photo upload button");


        public void GetRandomCheckboxes(int numberOfHobbies)
        {
            UnselectAll.ClickAndWait();


            IList<ICheckBox> allCheckboxes = new List<ICheckBox>(AllCheckboxes);

            List<ICheckBox> randomCheckboxes = new List<ICheckBox>();
            Random random = new Random();

            while (randomCheckboxes.Count < numberOfHobbies && allCheckboxes.Count > 0)
            {
                int randomIndex = random.Next(allCheckboxes.Count);
                ICheckBox checkbox = allCheckboxes[randomIndex];

                randomCheckboxes.Add(checkbox);
                allCheckboxes.RemoveAt(randomIndex);
            }

            foreach (ICheckBox checkbox in randomCheckboxes)
            {
                checkbox.State.WaitForClickable();
                checkbox.Click();
            }

        }



        public void SelectPhoto()
        {
            UploadPhoto.Click();
            Thread.Sleep(1000);
            string filePath = DataUtils.fullPath;
            inputSimulator.Keyboard.TextEntry(filePath);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            NextLink2.State.WaitForClickable();
            NextLink2.Click();


        }



    }
}
