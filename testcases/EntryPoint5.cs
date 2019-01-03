using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;


class EntryPoint5
    {
        static void Main()
        {

        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url: "http://newtours.demoaut.com/mercurywelcome.php");

        //href gia to support
        driver.FindElement(By.CssSelector("[href*= 'mercuryunderconst.php']")).Click();

        var homebutton = driver.FindElement(By.XPath("//img[@src='/images/forms/home.gif']"));

        if (homebutton.Displayed)
        {
            
            System.Console.WriteLine("Homepage Found");
        }
        else
        {
            System.Console.WriteLine("Homepage not Found");
        }


        driver.Quit();

    }
    }

