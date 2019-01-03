using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class EntryPoint2
{
    static void Main()
    {

        IWebDriver driver = new ChromeDriver();
        //string ClassName = "text";

        //Open Webpage
        driver.Navigate().GoToUrl(url: "http://newtours.demoaut.com/mercurywelcome.php");

        //sign-on
        driver.FindElement(By.CssSelector("[href*='mercurysignon.php']")).Click();

        try
            {
                
             //Search with name
            IWebElement celement = driver.FindElement(By.Name("userName"));
            System.Console.WriteLine("Page found");
        }
            catch
            {
               
                System.Console.WriteLine("Page not found");
            }

        //register
        driver.FindElement(By.CssSelector("[href*='mercuryregister.php']")).Click();
        try
        {

            //Search with name
            IWebElement celement = driver.FindElement(By.Name("firstName"));
            System.Console.WriteLine("Page found");
        }
        catch
        {

            System.Console.WriteLine("Page not found");
        }

        //support
        driver.FindElement(By.CssSelector("[href*='mercuryunderconst.php']")).Click();
        try
        {

            //Search with name
            IWebElement celement = driver.FindElement(By.Name("firstName"));
            System.Console.WriteLine("Page found");
        }
        catch
        {

            System.Console.WriteLine("Page not found");
        }

        //contact 
        driver.FindElement(By.CssSelector("[href*='mercuryunderconst.php']")).Click();
        try
        {

            //Search with name
            IWebElement celement = driver.FindElement(By.Name("firstName"));
            System.Console.WriteLine("Page found");
        }
        catch
        {

            System.Console.WriteLine("Page not found");
        }


        driver.Quit();

    }
}







