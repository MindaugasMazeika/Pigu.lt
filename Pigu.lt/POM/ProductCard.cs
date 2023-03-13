using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pigu.lt.POM
{
    internal class ProductCard
    {
        IWebDriver driver;
        public ProductCard(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ValidateMainInfo()
        {
            IWebElement productName = driver.FindElement(By.XPath("//h1[@itemprop='name']"));
            IWebElement productImage = driver.FindElement(By.XPath("//img[@itemprop='image']"));
            IWebElement productPrice = driver.FindElement(By.XPath("//div[@itemprop='offers']"));
            IWebElement addToCartButton = driver.FindElement(By.XPath("//div[contains(@class,'product-info')]//span[text()='Pridėti į krepšelį']"));
            IWebElement productSpecs = driver.FindElement(By.XPath("//div[@id='content-tabs']"));

            Assert.IsTrue(productName.Displayed);
            Assert.IsTrue(productImage.Displayed);
            Assert.IsTrue(productPrice.Displayed);
            Assert.IsTrue(addToCartButton.Displayed);
            Assert.IsTrue(productSpecs.Displayed);

        }

        public void ValidateOtherSections() {

            IWebElement similarItemsSection = driver.FindElement(By.XPath("(//div[contains(@class,'retailrocket-items')])[1]"));
            IWebElement buyExtra = driver.FindElement(By.XPath("(//div[contains(@class,'retailrocket-items')])[2]"));
            IWebElement wholeTopbar = driver.FindElement(By.XPath("//header[@class='header']"));
            IWebElement promoBlueLine = driver.FindElement(By.XPath("//div[@class='promo-sale ui-footer']"));

            Assert.IsTrue(similarItemsSection.Displayed);
            Assert.IsTrue(buyExtra.Displayed);
            Assert.IsTrue(wholeTopbar.Displayed);
            Assert.IsTrue(promoBlueLine.Displayed);
        }






    }
}
