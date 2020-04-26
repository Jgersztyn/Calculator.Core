using System;
using Xunit;
using Bunit;
using Shouldly;
using Bunit.Mocking.JSInterop;

using Calculator.Core.Pages;

namespace Calculator.Tests.bUnit
{
    public class CalculatorTest : ComponentTestFixture
    {
        [Fact]
        public void AddingTwoNumbersProducesCorrectResult()
        {
            // Renders the Counter component
            var page = RenderComponent<CalculatorComponent>();

            // Use a Find to query the rendered DOM tree and find the button element
            // and trigger the @onclick event handler by calling Click
            page.Find("#two").Click();

            page.Find("#plus").Click();

            page.Find("#two").Click();

            page.Find("#equals").Click();

            // Use a Find to query the rendered DOM tree and find the paragraph element
            // and assert that its text content is the expected (calling Trim first to remove insignificant whitespace)
            page.Find("#result").TextContent.Trim().ShouldBe("4");
        }
    }
}