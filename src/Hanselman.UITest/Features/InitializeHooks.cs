using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Hanselman.UITest.Features
{
    [Binding]
    public sealed class InitializeHooks
    {
        private readonly ScenarioContext scenarioContext;

        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        public InitializeHooks(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }
        
        
        [BeforeScenario]
        public void BeforeScenario()
        {
            var appiumDriver = new AppiumDriver();
            appiumDriver.InitializeAppium();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}