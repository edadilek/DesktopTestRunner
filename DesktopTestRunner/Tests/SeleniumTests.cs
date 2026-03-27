using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace DesktopTestRunner
{
    public static class SeleniumTests
    {
        public static bool TestLogin(string url)
        {
            var options = new ChromeOptions();
            options.AddArgument("--headless"); 
            using var driver = new ChromeDriver(options);
            try
            {
                driver.Navigate().GoToUrl(url);
                driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
                driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
                driver.FindElement(By.Id("login-button")).Click();

                return driver.Title.Contains("Swag Labs");
            }
            catch
            {
                return false;
            }
        }

        public static bool TestAddToCart(string url)
        {
            var options = new ChromeOptions();
            options.AddArgument("--headless");
            using var driver = new ChromeDriver(options);
            try
            {
                driver.Navigate().GoToUrl(url);
                driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
                driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
                driver.FindElement(By.Id("login-button")).Click();

                driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();

                return driver.FindElement(By.ClassName("shopping_cart_badge")).Text == "1";
            }
            catch
            {
                return false;
            }
        }
    }
}
