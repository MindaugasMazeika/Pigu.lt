using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pigu.lt.POM
{
    internal class ProductList
    {
        IWebDriver driver;
        GeneralMethods generalMethods;
        public ProductList(IWebDriver driver)
        {
            this.driver = driver;
            generalMethods = new GeneralMethods(driver);
        }

        public void SelectProduct(int x)
        {
            IJavaScriptExecutor javascriptExecutor = (IJavaScriptExecutor)driver;
            javascriptExecutor.ExecuteScript("arguments[0].click();", 
            driver.FindElement(By.XPath("(//div[contains(@class,'main-block')]//a[@class='cover-link'])["+x+"]")));
        }
    }


}
