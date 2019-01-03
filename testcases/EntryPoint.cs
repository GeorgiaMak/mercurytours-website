using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class EntryPoint
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();
       

        //Open Webpage
        driver.Navigate().GoToUrl(url: "http://newtours.demoaut.com/mercurywelcome.php");

        //Enter username and password
        driver.FindElement(By.Name("userName")).SendKeys("georgia_m");

        driver.FindElement(By.Name("password")).SendKeys("Georgia2018");

        driver.FindElement(By.Name("login")).Click();

        IWebElement LoginElement = driver.FindElement(By.Name("findflight"));



        //Check for valid or invalid login
        if (LoginElement.Displayed)
        {
            
            System.Console.WriteLine("Valid login");


        }
        else
        {
            System.Console.WriteLine("Invalid login");
        }

        

        

        driver.Quit();

    }

    
 

}


