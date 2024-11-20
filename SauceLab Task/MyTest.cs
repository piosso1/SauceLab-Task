using NUnit.Framework;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace SauceLab_Task
{
    

    public class MyTest
    {
        //[TestMethod]
        public void TestMethod1()
        {
            //setting up browser in incognitomoe
            //var options = new EdgeDriver();
            //options.AddArgument("--inprivate");

            // Set up Edge options to use incognito mode
            var options = new EdgeOptions();
            options.AddArgument("--inprivate");

            // Initialize the Edge driver with the options
            IWebDriver driver = new EdgeDriver(options);

            // Navigate to the URL
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            // Maximize the browser window
            driver.Manage().Window.Maximize();


            // logining in with a valid credential
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            driver.FindElement(By.Id("login-button")).Click();

            // Verify successful login  and that  the user is redirected to the products page.
            IWebElement tittleName = driver.FindElement(By.ClassName("title"));
            string expectedItemName = "Products";
            //Assert.AreEqual(expectedItemName, tittleName.Text, "Products page is  displayed as expected.");
           


            IWebElement tshirt = driver.FindElement(By.Id("item_1_img_link"));
            tshirt.Click();

            //IWebElement dicrip = driver.FindElement(By.ClassName("inventory_details_desc large_size"));
            // Assert.AreEqual(tst, "Get your testing superhero on with the Sauce Labs bolt T-shirt. From American Apparel, 100% ringspun combed cotton, heather gray with red bolt.");


            driver.FindElement(By.Id("add-to-cart")).Click();

            //Verify that the cart page is displayed.
            //IWebElement tittleCart = driver.FindElement(By.ClassName("title"));
            //string expectedpage = "Your Cart";
            //Assert.AreEqual(expectedpage, tittleCart.Text, "Your Cart page is  displayed as expected.");


            //Navigate to the cart by clicking the cart icon or accessing the cart page directly.
            driver.FindElement(By.ClassName("shopping_cart_link")).Click();

            //Click the "Checkout" button.
            driver.FindElement(By.Id("checkout")).Click();

            //Enter the required checkout information (e.g., name, shipping address, payment details).
            driver.FindElement(By.Id("first-name")).SendKeys("Patrick");
            driver.FindElement(By.Id("last-name")).SendKeys("Udo");
            driver.FindElement(By.Id("postal-code")).SendKeys("500102");

            //Click the "Continue" button.
            driver.FindElement(By.Id("continue")).Click();

            //Click the "Finish" button.
            driver.FindElement(By.Id("finish")).Click();

            // back to product page
            driver.FindElement(By.Id("back-to-products")).Click();



            driver.Quit();






        }
    }
}
