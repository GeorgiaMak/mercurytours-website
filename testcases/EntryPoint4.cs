using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

class EntryPoint4
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


            IWebElement RadioButton = driver.FindElement(By.Name("tripType"));

            if (RadioButton.GetAttribute("checked") == "true")
            {
                
                var DropDownMenu = driver.FindElement(By.Name("passCount"));
                var passno = new SelectElement(DropDownMenu);
                passno.SelectByValue("3");
   
                var DropDownMenu1 = driver.FindElement(By.Name("fromPort"));
                var dept = new SelectElement(DropDownMenu1);
                dept.SelectByValue("London");

               
                var DropDownMenu2 = driver.FindElement(By.Name("fromMonth"));
                var month = new SelectElement(DropDownMenu2);
                month.SelectByValue("11");

                var DropDownMenu3 = driver.FindElement(By.Name("fromDay"));
                var date = new SelectElement(DropDownMenu3);
                date.SelectByValue("2");

                var DropDownMenu4 = driver.FindElement(By.Name("toPort"));
                var arrival = new SelectElement(DropDownMenu4);
                arrival.SelectByValue("Frankfurt");

                var DropDownMenu5 = driver.FindElement(By.Name("toMonth"));
                var ret = new SelectElement(DropDownMenu5);
                ret.SelectByValue("11");

                var DropDownMenu6 = driver.FindElement(By.Name("toDay"));
                var retdate = new SelectElement(DropDownMenu6);
                retdate.SelectByValue("8");


                IWebElement ContinueButton = driver.FindElement(By.Name("findflight"));
               

                if (ContinueButton.Displayed)
                {
                    
                    driver.FindElement(By.XPath("//img[@src='/images/masts/mast_selectflight.gif']"));
                    System.Console.WriteLine("page found");

                }
                else
                {
                    System.Console.WriteLine("page not found");
                }

                
            }
            else
            {
                System.Console.WriteLine("page not found");
            }


        }
        else
        {
            System.Console.WriteLine("Invalid login");
        }



        driver.Quit();

    }
}








