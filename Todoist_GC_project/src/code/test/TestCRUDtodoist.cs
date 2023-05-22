using SeleniumTraining.src.code.page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.test
{
    [TestClass]
    public class TestCRUDtodoist : TestBase
    {
        
        MainPage mainPage = new MainPage();
        LoginSection loginSection = new LoginSection();
        LeftSection leftSection = new LeftSection();

        [TestMethod]
        public void VerifyCRUDProject()
        {
            mainPage.loginButton.Click();
            loginSection.Login("gabriel271085@gmail.com", "Mojix12345");

            //creation 
            leftSection.addNewProjectButton.Click();
            leftSection.projectNameTextBox.SetText("CRUDop");
            leftSection.addButton.Click();

            //creation assert
            Assert.IsTrue(leftSection.ProjectNameDisplayed("CRUDop"), "Error, project was not created");


            //update
            leftSection.ClickProjectName("CRUDop");
            leftSection.subMenuIcon.Click();
            leftSection.editButton.Click();
            leftSection.projectNameEditTextBox.SetText("CRUDopupdate");
            leftSection.saveChangesButton.Click();
            Thread.Sleep(2000);

            //update assert
            Assert.IsTrue(leftSection.ProjectNameDisplayed("CRUDopupdate"), "error, project was not updated");


            //delete

            leftSection.ClickProjectName("CRUDopupdate");
            leftSection.subMenuIcon.Click();
            leftSection.deleteButton.Click();
            leftSection.saveChangesButton.Click();
            Thread.Sleep(2000);

            //delete assert
            Assert.IsFalse(leftSection.ProjectNameDisplayed("CRUDopupdate"), "error, project was not deleted");


        }
    }
}

