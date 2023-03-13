using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.DevTools.V108.CSS;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Xml.Linq;
using System.Reflection.Emit;
using Pigu.lt.POM;

namespace Pigu.lt
{
    public class Testai
    {
        private static string driverPath = "C:\\Users\\Mindaugas\\Documents\\chromedriver.exe";
        static IWebDriver driver;

        [SetUp]
        public static void SETUP()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-notifications");
            driver = new ChromeDriver(options);
            driver.Url = "https://pigu.lt";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//div[@class='cookies_wrapper']//button[@type='button']")).Click();
        }

        [TearDown]
        public static void TearDown()
        {
            //driver.Quit();
        }

        [Test]
        public static void PaieškaIrValidacija()
        {
            GeneralMethods generalMethods = new GeneralMethods(driver);
            TopMenu topMenu = new TopMenu(driver);
            ProductList productList = new ProductList(driver);
            ProductCard productCard = new ProductCard(driver);  
            
            topMenu.SearchByText("Iphone 14");
            productList.SelectProduct(3);
            productCard.ValidateMainInfo(); 

        }















        [Test]
        public static void Krepšelis()
        {
          

        }
    }
}

