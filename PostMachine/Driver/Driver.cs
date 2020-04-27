using System;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;

namespace PostMachine
{
    public class Driver
    {
        const Int32 FindCssTimes = 40;
        const Int32 FindCssDelay = 500;
        const Int32 SymbolSendDelay = 10;

        static private List<Driver> Drivers = new List<Driver>();

        public Int32 DriverId { get; private set; }
        public Driver(int id) => DriverId = id;

        public static void Start(object thrID)
        {
            var threadId = (int)thrID;
            for (int i = threadId; i < VkAccount.Accounts.Count - 1; i += Form1.ThreadCount)
                StartNewDriver(i, VkAccount.Accounts[i]);
        }

        private static void StartNewDriver(int driverID, VkAccount account)
        {
            Driver driver = new Driver(driverID);
            Drivers.Add(driver);

            IWebDriver webDriver = new ChromeDriver();

            driver.StartJobbing(account, webDriver);
        }

        private void StartJobbing(VkAccount account, IWebDriver driver)
        {
            try { MakeAuthorize(account, driver); }
            catch
            {
                // Unable to auth info
                // Stop driver
                // Clear data
                // Info user
            }

            //try { StartPosting(account, driver); }
            //// TODO
            //// Reasons of driver stopped as exceptions
            //catch
            //{
            //    // TODO 
            //    // Clear driver info
            //    // Message to user
            //}

        }

        // VK AUHORIZATION
        private void MakeAuthorize(VkAccount account, IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://vk.com/");

            KeysSend(FindCss("#index_email", driver), account.Login);
            KeysSend(FindCss("#index_pass", driver), account.Password);
            KeysSend(FindCss("#index_pass", driver), OpenQA.Selenium.Keys.Return);
        }

        // ReWrite of Selenium methods
        private IWebElement FindCss(string css, IWebDriver driver)
        {
            while (true)
            {
                for (int i = 0; i < FindCssTimes; i++)
                {
                    try
                    {
                        var element = driver.FindElement(By.CssSelector(css));
                        if (element == null) throw new Exception("Unable to find css selector");

                        return element;
                    }
                    catch { Thread.Sleep(FindCssDelay); }
                }

                driver.Navigate().Refresh();
            }
        }

        private void KeysSend(IWebElement elementToSend, string keys)
        {
            foreach( char symbol in keys )
            {
                elementToSend.SendKeys(symbol.ToString());
                Thread.Sleep(SymbolSendDelay);
            }
        }
    }
}
