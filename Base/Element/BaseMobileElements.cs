﻿using OpenQA.Selenium.Appium;
using AutomationFrameWork.Base.Driver;
namespace AutomationFrameWork.Base
/// <summary>
///  This class will create MobileDriver for any class extend from it
///  MobileDriver use for findElement/findElements
/// </summary>
{
    public class BaseMobileElements
    {
        protected AppiumDriver<AppiumWebElement> MobileDriver;        
        public BaseMobileElements ()
        {
            this.MobileDriver = DriverFactory.Instance.GetMobileDriver;
        }
    }
}
