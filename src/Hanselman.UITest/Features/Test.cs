using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Hanselman.UITest.Features
{
    [Binding]
    public sealed class Test
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public Test(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"app launch")]
        public void GivenAppLaunch()
        {
            
        }

        [Given(@"App is there")]
        public void GivenAppIsThere()
        {
            
        }

        [When(@"I select stuff")]
        public void WhenISelectStuff()
        {
            
        }

        [Then(@"It should be good")]
        public void ThenItShouldBeGood()
        {
            
        }
    }
}