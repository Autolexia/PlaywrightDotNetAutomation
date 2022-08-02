using Microsoft.Playwright;

namespace PlaywrightAutomation.AutomationPractice.Pages
{
    internal class HomePage
    {
        private IPage _page;
        private readonly ILocator _signInButton;

        public HomePage(IPage page)
        {
            _page = page;
            _signInButton = _page.Locator("a[title='Log in to your customer account']");
        }

        public async Task ClickSignInButton() => await _signInButton.ClickAsync();
    }
}
