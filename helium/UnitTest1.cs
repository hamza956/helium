using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace helium
{
    [TestClass]
    public class heliumhealth:BaseClass
    {
        private TestContext instance;

        public TestContext TestContext

        {

            set { instance = value; }

            get { return instance; }

        }
        By submitbtn = By.XPath("//p[contains(text(),'Contact Us')]");
        By firstName = By.Id("input_1_1");
        By lastName = By.Id("input_1_2");
        By email = By.Id("input_1_5");
        By phoneNumber = By.Id("input_1_6");
        By hospitalName = By.Id("input_1_7");
        By location = By.Id("input_1_9");
        By estimatedPatuents = By.Id("input_1_10");
        By message = By.Id("input_1_11");
        // By clickbtn = By.Id("gform_submit_button_1");


        //Verify the Contact us page if User Add all valid details

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "data#csv", "data1.csv", DataAccessMethod.Sequential)]
        public void TestMethod1()
           
        {
            string browser = TestContext.DataRow[0].ToString();
            string link = TestContext.DataRow[1].ToString();
            string FirstName = TestContext.DataRow[2].ToString();
            string lastname = TestContext.DataRow[3].ToString();
            string Email = TestContext.DataRow[4].ToString();
            string phone= TestContext.DataRow[5].ToString();
            string hospital= TestContext.DataRow[6].ToString();
            string Location=TestContext.DataRow[7].ToString();
            string patients = TestContext.DataRow[8].ToString();
            string ymessage = TestContext.DataRow[9].ToString();


            urlbrowser(browser, link);
            Click(submitbtn);
            Thread.Sleep(5000);

            
            Write(firstName, FirstName);
            Thread.Sleep(5000);
            Write(lastName, lastname);
            Write(email, Email);
            Thread.Sleep(4000);
            Write(phoneNumber, phone);
            Thread.Sleep(4000);
            Write(hospitalName,hospital);
            Write(location, Location);
            Write(estimatedPatuents, patients);
            Write(message, ymessage);
            Thread.Sleep(5000);
            //Click(clickbtn);
            IWebElement cl = driver.FindElement(By.Id("gform_submit_button_1"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", cl);
        }
        //verify the contact us page with invalid email
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "data#csv", "data2.csv", DataAccessMethod.Sequential)]
        public void TestMethod2()

        {
            string browser = TestContext.DataRow[0].ToString();
            string link = TestContext.DataRow[1].ToString();
            string FirstName = TestContext.DataRow[2].ToString();
            string lastname = TestContext.DataRow[3].ToString();
            string Email = TestContext.DataRow[4].ToString();
            string phone = TestContext.DataRow[5].ToString();
            string hospital = TestContext.DataRow[6].ToString();
            string Location = TestContext.DataRow[7].ToString();
            string patients = TestContext.DataRow[8].ToString();
            string ymessage = TestContext.DataRow[9].ToString();


            urlbrowser(browser, link);
            Click(submitbtn);
            Thread.Sleep(5000);


            Write(firstName, FirstName);
            Thread.Sleep(5000);
            Write(lastName, lastname);
            Write(email, Email);
            Thread.Sleep(4000);
            Write(phoneNumber, phone);
            Thread.Sleep(4000);
            Write(hospitalName, hospital);
            Write(location, Location);
            Write(estimatedPatuents, patients);
            Write(message, ymessage);
            Thread.Sleep(5000);
            //Click(clickbtn);
            IWebElement cl = driver.FindElement(By.Id("gform_submit_button_1"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", cl);
            //Thread.Sleep(5000);
            ////string comparestack = driver.FindElement(By.CssSelector("#gform_1_validation_container > h2")).ToString();
            Thread.Sleep(5000);
            //Assert.AreEqual("There was a problem with your submission. Please review the fields below.", comparestack);
        }

        //Verify contact form with minimum phone length
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "data#csv", "data3.csv", DataAccessMethod.Sequential)]
        public void TestMethod3()

        {
            string browser = TestContext.DataRow[0].ToString();
            string link = TestContext.DataRow[1].ToString();
            string FirstName = TestContext.DataRow[2].ToString();
            string lastname = TestContext.DataRow[3].ToString();
            string Email = TestContext.DataRow[4].ToString();
            string phone = TestContext.DataRow[5].ToString();
            string hospital = TestContext.DataRow[6].ToString();
            string Location = TestContext.DataRow[7].ToString();
            string patients = TestContext.DataRow[8].ToString();
            string ymessage = TestContext.DataRow[9].ToString();


            urlbrowser(browser, link);
            Click(submitbtn);
            Thread.Sleep(5000);


            Write(firstName, FirstName);
            Thread.Sleep(5000);
            Write(lastName, lastname);
            Write(email, Email);
            Thread.Sleep(4000);
            Write(phoneNumber, phone);
            Thread.Sleep(4000);
            Write(hospitalName, hospital);
            Write(location, Location);
            Write(estimatedPatuents, patients);
            Write(message, ymessage);
            Thread.Sleep(5000);
            //Click(clickbtn);
            IWebElement cl = driver.FindElement(By.Id("gform_submit_button_1"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", cl);
            //Thread.Sleep(5000);
            ////string comparestack = driver.FindElement(By.CssSelector("#gform_1_validation_container > h2")).ToString();
            Thread.Sleep(5000);
            //Assert.AreEqual("There was a problem with your submission. Please review the fields below.", comparestack);
        }
        //Verify the contact form without any detail
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "data#csv", "data4.csv", DataAccessMethod.Sequential)]
        public void TestMethod4()

        {
            string browser = TestContext.DataRow[0].ToString();
            string link = TestContext.DataRow[1].ToString();
            string FirstName = TestContext.DataRow[2].ToString();
            string lastname = TestContext.DataRow[3].ToString();
            string Email = TestContext.DataRow[4].ToString();
            string phone = TestContext.DataRow[5].ToString();
            string hospital = TestContext.DataRow[6].ToString();
            string Location = TestContext.DataRow[7].ToString();
            string patients = TestContext.DataRow[8].ToString();
            string ymessage = TestContext.DataRow[8].ToString();


            urlbrowser(browser, link);
            Click(submitbtn);
            Thread.Sleep(5000);


            Write(firstName, FirstName);
            Thread.Sleep(5000);
            Write(lastName, lastname);
            Write(email, Email);
            Thread.Sleep(4000);
            Write(phoneNumber, phone);
            Thread.Sleep(4000);
            Write(hospitalName, hospital);
            Write(location, Location);
            Write(estimatedPatuents, patients);
            Write(message, ymessage);
            Thread.Sleep(5000);
            //Click(clickbtn);
            IWebElement cl = driver.FindElement(By.Id("gform_submit_button_1"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", cl);
            //Thread.Sleep(5000);
            ////string comparestack = driver.FindElement(By.CssSelector("#gform_1_validation_container > h2")).ToString();
            Thread.Sleep(5000);
            //Assert.AreEqual("There was a problem with your submission. Please review the fields below.", comparestack);
        }

        //Verify contact form by using special character as a hospital name
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "data#csv", "data1.csv", DataAccessMethod.Sequential)]
        public void TestMethod10()

        {
            string browser = TestContext.DataRow[0].ToString();
            string link = TestContext.DataRow[1].ToString();
            string FirstName = TestContext.DataRow[2].ToString();
            string lastname = TestContext.DataRow[3].ToString();
            string Email = TestContext.DataRow[4].ToString();
            string phone = TestContext.DataRow[5].ToString();
            string hospital = TestContext.DataRow[6].ToString();
            string Location = TestContext.DataRow[7].ToString();
            string patients = TestContext.DataRow[8].ToString();
            string ymessage = TestContext.DataRow[8].ToString();


            urlbrowser(browser, link);
            Click(submitbtn);
            Thread.Sleep(5000);


            Write(firstName, FirstName);
            Thread.Sleep(5000);
            Write(lastName, lastname);
            Write(email, Email);
            Thread.Sleep(4000);
            Write(phoneNumber, phone);
            Thread.Sleep(4000);
            Write(hospitalName, "&@#$#@@");
            Write(location, Location);
            Write(estimatedPatuents, patients);
            Write(message, ymessage);
            Thread.Sleep(5000);
            //Click(clickbtn);
            IWebElement cl = driver.FindElement(By.Id("gform_submit_button_1"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", cl);
            //Thread.Sleep(5000);
            ////string comparestack = driver.FindElement(By.CssSelector("#gform_1_validation_container > h2")).ToString();
            Thread.Sleep(5000);
            //Assert.AreEqual("There was a problem with your submission. Please review the fields below.", comparestack);
        }
        //Verify Contact form by using special characters as a estimation patients
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "data#csv", "data1.csv", DataAccessMethod.Sequential)]
        public void TestMethod9()

        {
            string browser = TestContext.DataRow[0].ToString();
            string link = TestContext.DataRow[1].ToString();
            string FirstName = TestContext.DataRow[2].ToString();
            string lastname = TestContext.DataRow[3].ToString();
            string Email = TestContext.DataRow[4].ToString();
            string phone = TestContext.DataRow[5].ToString();
            string hospital = TestContext.DataRow[6].ToString();
            string Location = TestContext.DataRow[7].ToString();
            string patients = TestContext.DataRow[8].ToString();
            string ymessage = TestContext.DataRow[8].ToString();


            urlbrowser(browser, link);
            Click(submitbtn);
            Thread.Sleep(5000);


            Write(firstName, FirstName);
            Thread.Sleep(5000);
            Write(lastName, lastname);
            Write(email, Email);
            Thread.Sleep(4000);
            Write(phoneNumber, phone);
            Thread.Sleep(4000);
            Write(hospitalName, "&@#$#@@");
            Write(location, Location);
            Write(estimatedPatuents, "*@#$%###");
            Write(message, ymessage);
            Thread.Sleep(5000);
            //Click(clickbtn);
            IWebElement cl = driver.FindElement(By.Id("gform_submit_button_1"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", cl);
            //Thread.Sleep(5000);
            ////string comparestack = driver.FindElement(By.CssSelector("#gform_1_validation_container > h2")).ToString();
            Thread.Sleep(5000);
            //Assert.AreEqual("There was a problem with your submission. Please review the fields below.", comparestack);
        }
        //Verify Contact form by using special characters as a  last name 

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "data#csv", "data1.csv", DataAccessMethod.Sequential)]
        public void TestMethod8()

        {
            string browser = TestContext.DataRow[0].ToString();
            string link = TestContext.DataRow[1].ToString();
            string FirstName = TestContext.DataRow[2].ToString();
            string lastname = TestContext.DataRow[3].ToString();
            string Email = TestContext.DataRow[4].ToString();
            string phone = TestContext.DataRow[5].ToString();
            string hospital = TestContext.DataRow[6].ToString();
            string Location = TestContext.DataRow[7].ToString();
            string patients = TestContext.DataRow[8].ToString();
            string ymessage = TestContext.DataRow[8].ToString();


            urlbrowser(browser, link);
            Click(submitbtn);
            Thread.Sleep(5000);


            Write(firstName, FirstName);
            Thread.Sleep(5000);
            Write(lastName, "&@#$#@@");
            Write(email, Email);
            Thread.Sleep(4000);
            Write(phoneNumber, phone);
            Thread.Sleep(4000);
            Write(hospitalName, hospital);
            Write(location, Location);
            Write(estimatedPatuents, patients);
            Write(message, ymessage);
            Thread.Sleep(5000);
            //Click(clickbtn);
            IWebElement cl = driver.FindElement(By.Id("gform_submit_button_1"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", cl);
            //Thread.Sleep(5000);
            ////string comparestack = driver.FindElement(By.CssSelector("#gform_1_validation_container > h2")).ToString();
            Thread.Sleep(5000);
            //Assert.AreEqual("There was a problem with your submission. Please review the fields below.", comparestack);
        }
        //Verify Form by using special characters in first name

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "data#csv", "data1.csv", DataAccessMethod.Sequential)]
        public void TestMethod7()

        {
            string browser = TestContext.DataRow[0].ToString();
            string link = TestContext.DataRow[1].ToString();
            string FirstName = TestContext.DataRow[2].ToString();
            string lastname = TestContext.DataRow[3].ToString();
            string Email = TestContext.DataRow[4].ToString();
            string phone = TestContext.DataRow[5].ToString();
            string hospital = TestContext.DataRow[6].ToString();
            string Location = TestContext.DataRow[7].ToString();
            string patients = TestContext.DataRow[8].ToString();
            string ymessage = TestContext.DataRow[8].ToString();


            urlbrowser(browser, link);
            Click(submitbtn);
            Thread.Sleep(5000);


            Write(firstName, "&@#$#@@");
            Thread.Sleep(5000);
            Write(lastName, lastname);
            Write(email, Email);
            Thread.Sleep(4000);
            Write(phoneNumber, phone);
            Thread.Sleep(4000);
            Write(hospitalName, hospital);
            Write(location, Location);
            Write(estimatedPatuents, patients);
            Write(message, ymessage);
            Thread.Sleep(5000);
            //Click(clickbtn);
            IWebElement cl = driver.FindElement(By.Id("gform_submit_button_1"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", cl);
            //Thread.Sleep(5000);
            ////string comparestack = driver.FindElement(By.CssSelector("#gform_1_validation_container > h2")).ToString();
            Thread.Sleep(5000);
            //Assert.AreEqual("There was a problem with your submission. Please review the fields below.", comparestack);
        }

        //Verify that user is able to enter  maximum length in the message text field or not.


          [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "data#csv", "data1.csv", DataAccessMethod.Sequential)]
        public void TestMethod6()

        {
            string browser = TestContext.DataRow[0].ToString();
            string link = TestContext.DataRow[1].ToString();
            string FirstName = TestContext.DataRow[2].ToString();
            string lastname = TestContext.DataRow[3].ToString();
            string Email = TestContext.DataRow[4].ToString();
            string phone = TestContext.DataRow[5].ToString();
            string hospital = TestContext.DataRow[6].ToString();
            string Location = TestContext.DataRow[7].ToString();
            string patients = TestContext.DataRow[8].ToString();
            string ymessage = TestContext.DataRow[8].ToString();


            urlbrowser(browser, link);
            Click(submitbtn);
            Thread.Sleep(5000);


            Write(firstName, FirstName);
            Thread.Sleep(5000);
            Write(lastName, lastname);
            Write(email, Email);
            Thread.Sleep(4000);
            Write(phoneNumber, phone);
            Thread.Sleep(4000);
            Write(hospitalName, hospital);
            Write(location, Location);
            Write(estimatedPatuents, patients);
            Write(message, ymessage);
            Thread.Sleep(5000);
            //Click(clickbtn);
            IWebElement cl = driver.FindElement(By.Id("gform_submit_button_1"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", cl);
            //Thread.Sleep(5000);
            ////string comparestack = driver.FindElement(By.CssSelector("#gform_1_validation_container > h2")).ToString();
            Thread.Sleep(5000);
            //Assert.AreEqual("There was a problem with your submission. Please review the fields below.", comparestack);
        }

    }
}
