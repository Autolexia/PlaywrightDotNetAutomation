using Microsoft.Playwright;

namespace PlaywrightAutomation.AutomationPractice.Pages
{
    internal class AccountPage
    {
        private IPage _page;
        private readonly ILocator _createAccountEmailInput;
        private readonly ILocator _createAccountButton;


        public AccountPage(IPage page)
        {
            _page = page;

            _createAccountEmailInput = _page.Locator("input#email_create");
            _createAccountButton = _page.Locator("button#SubmitCreate > span");
        }

        public async Task InputEmail(string input) => await _createAccountEmailInput.TypeAsync(input);
        public async Task ClickCreateAccountButton() => await _createAccountButton.ClickAsync();
    }
}
