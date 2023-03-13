using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pigu.lt
{
    internal class GeneralMethods
    {
        IWebDriver driver;
        public GeneralMethods(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickElement(string xpath)
        {
            IWebElement el = driver.FindElement(By.XPath(xpath));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", el);
            el.Click();

        }

        public void EnterText(string xpath, string text)
        {
            By searchField = By.XPath(xpath);
            driver.FindElement(searchField).SendKeys(text);

        }
    }
}
