using Microsoft.Playwright.NUnit;

namespace PlaywrightAutomation.AutomationPractice;

public class Tests : PageTest
{
    [SetUp]
    async public Task Setup()
    {
        await Page.GotoAsync("http://automationpractice.com/index.php");
    }

    [Test]
    async public Task NavigateToSite()
    {
        await Expect(Page).ToHaveTitleAsync("My Store");
    }
}