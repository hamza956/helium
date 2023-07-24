using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helium
{
    public class BaseClass
    {
        public static IWebDriver driver;
        public IWebDriver browser(String browser)

        {
            if (browser == "chrome")
            {
                ChromeOptions chromeOption = new ChromeOptions();
                chromeOption.AddArguments("--start-maximized");
                // chromeOption.AddArguments("incognito");
                chromeOption.AddArguments("disable-popup-blocking");
                //chromeOption.AddArguments("headless");
                driver = new ChromeDriver(chromeOption);


                //driver = new ChromeDriver(chromeOption);
            }
            else if (browser == "edge")
            {
                EdgeOptions edgeOption = new EdgeOptions();
                edgeOption.AddArguments("--start-maximized");
                //edgeOption.AddArguments("-inprivate");
                edgeOption.AddArguments("disable-popup-blocking");
                //edgeOption.AddArguments("headless");
                driver = new EdgeDriver(edgeOption);
            }

            return driver;




        }

        public void urlbrowser(string bowser, string url)
        {
            browser(bowser);
            OpenUrl(url);
        }


        public void CloseDriver()

        {

            driver.Close();

        }
        public void Write(By by, String value)

        {

            driver.FindElement(by).SendKeys(value);

        }
        public void Click(By by)

        {

            driver.FindElement(by).Click();

        }
        public void Clear(By by)

        {

            driver.FindElement(by).Clear();

        }
        public void OpenUrl(String url)

        {

            driver.Url = url;




        }
       

    }

}
