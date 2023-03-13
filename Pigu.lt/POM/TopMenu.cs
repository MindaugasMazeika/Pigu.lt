using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pigu.lt.POM
{
    internal class TopMenu
    {
        IWebDriver driver;
        GeneralMethods generalMethods;
        public TopMenu(IWebDriver driver)
        {
            this.driver = driver;
            generalMethods = new GeneralMethods(driver);
        }
        public void SearchByText(string text)
        {
            generalMethods.EnterText("//input[@id='searchInput']", text);
            generalMethods.ClickElement("//i[@class='c-icon--search']");


        }
    }
}
