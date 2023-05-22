using OpenQA.Selenium;
using SeleniumTraining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.page
{
    public class LeftSection
    {
        //creacion
        public Button addNewProjectButton = new Button(By.XPath("//button[contains(@aria-label,\"Add project\")]"));
        public TextBox projectNameTextBox = new TextBox(By.XPath("//input[@id=\"edit_project_modal_field_name\"]"));
        public Button addButton = new Button(By.XPath("//button[@type=\"submit\"]"));

        //edicion
        public Button subMenuIcon = new Button(By.XPath("(//ul[@id=\"projects_list\"]/li/div/div/div/button)[last()]"));
        public Button editButton = new Button(By.XPath("//ul[@role=\"menu\"]/li/div/div[text()='Edit project']"));
        public TextBox projectNameEditTextBox = new TextBox(By.XPath("//input[@id=\"edit_project_modal_field_name\"]"));
        public Button saveChangesButton = new Button(By.XPath("//button[@type=\"submit\"]\r\n"));

        //eliminacion

        public Button deleteButton = new Button(By.XPath("//ul[@role=\"menu\"]/li/div/div[text()='Delete project']"));


        public Boolean ProjectNameDisplayed(String nameValue)
        {
            Label nameProject = new Label(By.XPath("(//ul[@id=\"projects_list\"]/li/div/div/a/span[text()='"+ nameValue +"'])[last()]"));
            return nameProject.IsControlDisplayed();


        }

        public void ClickProjectName(String nameValue)
        {
            Label nameProject = new Label(By.XPath("(//ul[@id=\"projects_list\"]/li/div/div/a/span[text()='"+ nameValue +"'])[last()]"));
            nameProject.Click();
        }
        

    }
}
