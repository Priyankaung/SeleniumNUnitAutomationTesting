using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SampleProject
{
    class SampleClass
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:\\chrome");
        }

        [Test]
        public void IsURLisWorking()
        {
            driver.Url = "https://car.iselect.com.au/car/compare-car-insurance/gatewayStore";
        }

        [Test]
        public void PrintDefaultValueofMakeElement()
        {
            driver.Url = "https://car.iselect.com.au/car/compare-car-insurance/gatewayStore";
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(5000); //Waiting for the page to load, in case of network delay
            IWebElement element = driver.FindElement(By.XPath("//*[@id='root']/div[1]/section[1]/div/div[2]/div/div[1]/div/div[2]")); //Xpath of Make Element
            Console.WriteLine(element.Text == "Make"); //Useful for regression testing to ensure this values never changes while new code enhancements
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
