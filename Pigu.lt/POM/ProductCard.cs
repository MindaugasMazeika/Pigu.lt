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
            IWebElement productName = driver.FindElement(By.XPath("//div[@class='site-block']//h1"));
            IWebElement productImage = driver.FindElement(By.XPath("//div[@id='product-media']"));
            IWebElement productPrice = driver.FindElement(By.XPath("//div[@class='c-product__price']"));
            IWebElement addToCartButton = driver.FindElement(By.XPath("//div[@widget-attachpoint='addToCart']"));
            IWebElement productDescription = driver.FindElement(By.XPath("//div[@id='description']"));

            Assert.IsTrue(productName.Displayed);
            Assert.IsTrue(productImage.Displayed);
            Assert.IsTrue(productPrice.Displayed);
            Assert.IsTrue(addToCartButton.Displayed);
            Assert.IsTrue(productDescription.Displayed);
        }

        public void ValidateOtherSections() { 
        
        }






    }
}
