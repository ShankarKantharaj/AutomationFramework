﻿using AutomationFrameWork.Driver.Interface;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AutomationFrameWork.Driver
{
    class Nexus6 : IDrivers
    {
        public Nexus6() { }
        public object Driver
        {
            get; set;
        }

        public object DesiredCapabilities
        {
            get
            {
                ChromeOptions options = new ChromeOptions();
                options.LeaveBrowserRunning = true;
                options.EnableMobileEmulation("Google Nexus 6");
                return options;
            }
        }

        public object DriverServices
        {
            get
            {
                ChromeDriverService serivces = ChromeDriverService.CreateDefaultService();
                serivces.EnableVerboseLogging = false;
                serivces.HideCommandPromptWindow = true;
                serivces.SuppressInitialDiagnosticInformation = false;
                return serivces;
            }
        }
      
        public void StartDriver(DriverConfiguration configuration)
        {
            configuration.DriverServices = configuration.DriverServices ?? DriverServices;
            configuration.DesiredCapabilities = configuration.DesiredCapabilities ?? DesiredCapabilities;
            var options = (ChromeOptions)configuration.DesiredCapabilities;
            options.EnableMobileEmulation("Google Nexus 6");
            IWebDriver driver = new ChromeDriver((ChromeDriverService)configuration.DriverServices, options, TimeSpan.FromSeconds(configuration.CommandTimeout));
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(configuration.PageLoadTimeout));
            driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(configuration.ScriptTimeout));
            if (configuration.MaximizeBrowser)
                driver.Manage().Window.Maximize();
            Driver = driver;
        }
    }
}
