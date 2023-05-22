using OpenQA.Selenium;
using SeleniumTraining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.page
{
    public class LoginSection
    {
        public TextBox emailtextbox = new TextBox(By.XPath("//input[@type=\"email\"]"));
        public TextBox pwdtextbox = new TextBox(By.XPath("//input[@type=\"password\"]"));
        public Button loginbutton = new Button(By.XPath("//button[@type=\"submit\"]"));

        public void Login(String user, String password) 
        {
            emailtextbox.SetText(user);
            pwdtextbox.SetText(password);
            loginbutton.Click();
        }
    }
}
