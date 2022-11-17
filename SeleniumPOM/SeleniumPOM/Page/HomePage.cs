﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebDriver = SeleniumPOM.Driver.WebDriver;

namespace SeleniumPOM.Page;

public class HomePage
{
    private IWebDriver driver = WebDriver.Instance;

    public IWebElement Initial => driver.FindElement(By.Id("Initial"));
    public IWebElement FirstName => driver.FindElement(By.Id("FirstName"));
    public IWebElement MiddleName => driver.FindElement(By.Id("MiddleName"));
    public IWebElement Female => driver.FindElement(By.Name("Female"));
    public IWebElement Hindi => driver.FindElement(By.Name("Hindi"));
    public IWebElement SaveButton => driver.FindElement(By.Name("Save"));
    public IWebElement HtmlPopup => driver.FindElement(By.LinkText("HtmlPopup"));
    public IWebElement Generate => driver.FindElement(By.Name("generate"));




    public void Title(string option)
    {
        SelectElement drop = new SelectElement(driver.FindElement(By.Id("TitleId")));
        drop.SelectByText(option); // ovo vam sluzi da izabere iz drop downa Mr. ili Ms. potrebno je da mu u test kazete sta od ova dva zelite da izbare
    }
    public void Alert()
    {
        Generate.Click();
        driver.SwitchTo().Alert().Accept();
        
    }


}
