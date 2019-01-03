using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class EntryPoint1
  {
      static void Main()
        {

        IWebDriver driver = new ChromeDriver();
        string SearchText= "text";
        string errormsg = "mouseOut";
       

        //Open Webpage
        driver.Navigate().GoToUrl(url: "http://newtours.demoaut.com/mercurywelcome.php");

        //home
        driver.FindElement(By.CssSelector("[href*='mercurywelcome.php']")).Click();
        
        try
        {

            IWebElement celement = driver.FindElement(By.Name("home"));
            System.Console.WriteLine("Found");
            
        }
        catch
        {

            System.Console.WriteLine("not found");
        }

        //flights
        driver.FindElement(By.CssSelector("[href*='mercuryreservation.php']")).Click();

        try
        {

            IWebElement celement = driver.FindElement(By.ClassName(SearchText));
            System.Console.WriteLine("Found");
            
        }
        catch
        {
           
           System.Console.WriteLine("not found");
        }

        //hotels

        driver.FindElement(By.CssSelector("[href*='mercuryunderconst.php']")).Click();

        try
        {

            IWebElement celement = driver.FindElement(By.ClassName(errormsg));
            System.Console.WriteLine("Found");
            
        }
        catch
        {
            
            System.Console.WriteLine("not found");
        }

        //car rentals

        driver.FindElement(By.CssSelector("[href*='mercuryunderconst.php']")).Click();

        try
        {

            IWebElement celement = driver.FindElement(By.ClassName(errormsg));
            System.Console.WriteLine("Found");
           
        }
        catch
        {
           
            System.Console.WriteLine("not found");
        }


        //cruises
        driver.FindElement(By.CssSelector("[href*='mercurycruise.php']")).Click();
       
        try
            {

            driver.FindElement(By.CssSelector("/images/spacer.gif")).Click();
            System.Console.WriteLine("Found");
           
        }
            catch 
            {
               
                System.Console.WriteLine("not found");
            }



        //destination
        driver.FindElement(By.CssSelector("[href*='mercuryunderconst.php']")).Click();
        try
        {

            IWebElement celement = driver.FindElement(By.ClassName(errormsg));
            System.Console.WriteLine("Found");
            
        }
        catch
        {

            System.Console.WriteLine("not found");
        }



        //vacation
        driver.FindElement(By.CssSelector("[href*='mercuryunderconst.php']")).Click();
        try
        {

            IWebElement celement = driver.FindElement(By.ClassName(errormsg));
            System.Console.WriteLine("Found");
            
        }
        catch
        {

            System.Console.WriteLine("not found");
        }


        driver.Quit();
    }
        
        





       

    }








        
  

