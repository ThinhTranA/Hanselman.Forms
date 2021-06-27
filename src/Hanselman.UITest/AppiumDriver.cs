using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.iOS;

namespace Hanselman.UITest
{
    public class AppiumDriver
    {
        public AppiumDriver<AppiumWebElement> Driver { get; set; }

        public IOSDriver<AppiumWebElement> InitializeAppium()
        {
            var driverOptions = new AppiumOptions();
            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "iOS");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "iPhone 12");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.AutomationName, "XCUITest");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.App, "/Users/ttran/Desktop/Hanselman.Forms/src/iOS/bin/iPhoneSimulator/Debug/device-builds/iphone13.2-14.5/HanselmaniOS.app");

            return new IOSDriver<AppiumWebElement>(new Uri("http://localhost:4723/wd/hub"), driverOptions);
        }
    }
}