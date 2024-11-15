﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using System.Windows.Forms;

namespace seleniumPOC
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      var chromeOptions = new ChromeOptions();
      //chromeOptions.LeaveBrowserRunning = true;
      //chromeOptions.AddArguments("--headless=new"); // comment out for testing

      //var customUserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/117.0.0.0 Safari/537.36";
      //chromeOptions.AddArgument($"--user-agent={customUserAgent}");

      //var proxyURL = "213.33.2.28:80";
      //chromeOptions.AddArgument($"--proxy-server={proxyURL}");

      var chromeDriverService = ChromeDriverService.CreateDefaultService();
      chromeDriverService.HideCommandPromptWindow = true;

      var driver = new ChromeDriver(chromeDriverService, chromeOptions);
      driver.Url = "https://portalies.pravaler.com.br/gestao/extrato-repasse";

      try
      {
        WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
        wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));

        var by = By.XPath("//*[@id=\"username\"]");
        var element = driver.FindElement(by);
        element.SendKeys("xxxxxxxx");

        by = By.XPath("//*[@id=\"password\"]");
        element = driver.FindElement(by);
        element.SendKeys("xxxxxxx");

        by = By.XPath("//*[@id=\"__next\"]/div/div/div[3]/div/form/div[4]/button");
        element = driver.FindElement(by);
        element.Click();
        Thread.Sleep(TimeSpan.FromSeconds(10));

        by = By.XPath("//*[@id=\"startDate\"]");
        element = driver.FindElement(by);
        element.SendKeys("20/09/2024");

        by = By.XPath("//*[@id=\"endDate\"]");
        element = driver.FindElement(by);
        element.SendKeys("21/09");

        by = By.XPath("//*[@id=\"__next\"]/div/div/div[2]/div[2]/div[2]/div[2]/button");

        element = driver.FindElement(by);
        element.Click();
        Thread.Sleep(TimeSpan.FromSeconds(30));

        by = By.XPath("//*[@id=\"__next\"]/div/div/div[2]/div[2]/div[1]/div/div/button[2]");
        element = driver.FindElement(by);
        element.Click();
        Thread.Sleep(TimeSpan.FromSeconds(10));

        by = By.XPath("//*[@id=\"__next\"]/div/div/div[2]/div[2]/div[2]/div[2]/table/tbody/tr[1]/td[5]/button");
        element = driver.FindElement(by);
        element.Click();

        Thread.Sleep(TimeSpan.FromSeconds(15));
      }
      catch (Exception)
      {
        throw;
      }
      finally
      {
        driver.Quit();
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      var chromeOptions = new ChromeOptions();
      //chromeOptions.LeaveBrowserRunning = true;
      //chromeOptions.AddArguments("--headless=new"); // comment out for testing

      //var customUserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/117.0.0.0 Safari/537.36";
      //chromeOptions.AddArgument($"--user-agent={customUserAgent}");

      //var proxyURL = "213.33.2.28:80";
      //chromeOptions.AddArgument($"--proxy-server={proxyURL}");

      var chromeDriverService = ChromeDriverService.CreateDefaultService();
      chromeDriverService.HideCommandPromptWindow = true;

      var driver = new ChromeDriver(chromeDriverService, chromeOptions);
      //driver.Url = "https://portalies.pravaler.com.br/gestao/extrato-repasse";
      driver.Url = "https://portalies.pravaler.com.br/antecipacao/extrato";

      try
      {
        WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
        wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));

        var by = By.XPath("//*[@id=\"username\"]");
        var element = driver.FindElement(by);
        element.SendKeys("cruzeirodosul.josejunior");

        by = By.XPath("//*[@id=\"password\"]");
        element = driver.FindElement(by);
        element.SendKeys("Julia100413!!");

        by = By.XPath("//*[@id=\"__next\"]/div/div/div[3]/div/form/div[4]/button");
        element = driver.FindElement(by);
        element.Click();
        Thread.Sleep(TimeSpan.FromSeconds(10));

        by = By.XPath("//*[@id=\"startDate\"]");
        element = driver.FindElement(by);
        element.SendKeys("20/09/2024");

        by = By.XPath("//*[@id=\"endDate\"]");
        element = driver.FindElement(by);
        element.SendKeys("21/09");

        by = By.XPath("//*[@id=\"__next\"]/div/div/div[2]/div[2]/div[3]/div[2]/button");

        element = driver.FindElement(by);
        element.Click();
        Thread.Sleep(TimeSpan.FromSeconds(30));

        by = By.XPath("//*[@id=\"__next\"]/div/div/div[2]/div[2]/div[1]/div/div/button[2]");
        element = driver.FindElement(by);
        element.Click();
        Thread.Sleep(TimeSpan.FromSeconds(10));

        by = By.XPath("//*[@id=\"__next\"]/div/div/div[2]/div[2]/div[2]/div[2]/table/tbody/tr[1]/td[6]/button");
        element = driver.FindElement(by);
        element.Click();

        //var ss = ((ITakesScreenshot)driver).GetScreenshot();
        //ss.SaveAsFile("screenshot.png");

        Thread.Sleep(TimeSpan.FromSeconds(15));
      }
      catch (Exception)
      {
        throw;
      }
      finally
      {
        driver.Quit();
      }
    }


  }
}
