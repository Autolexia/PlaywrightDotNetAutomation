using Microsoft.Playwright;

namespace PlaywrightAutomation.AutomationPractice.Pages
{
    internal class CreateAccountPage
    {
        private IPage _page;
        private ILocator _titleMrOption;
        private ILocator _nameInput;
        private ILocator _surnameInput;
        private ILocator _passwordInput;
        private ILocator _birthdayDayDropdown;
        private ILocator _birthdayMonthDropdown;
        private ILocator _birthdayYearDropdown;
        private ILocator _streetAddressInput;
        private ILocator _cityInput;
        private ILocator _stateDropdown;
        private ILocator _postalCodeInput;
        private ILocator _mobileNumberInput;
        private ILocator _registerButton;

        public CreateAccountPage(IPage page)
        {
            _page = page;
            _titleMrOption = _page.Locator("div:nth-of-type(1) > .top > .radio  input[name='id_gender']");
            _nameInput = _page.Locator("input#customer_firstname");
            _surnameInput = _page.Locator("input#customer_lastname");
            _passwordInput = _page.Locator("input#passwd");
            _birthdayDayDropdown = _page.Locator("select#days");
            _birthdayMonthDropdown = _page.Locator("select#months");
            _birthdayYearDropdown = _page.Locator("select#years");
            _streetAddressInput = _page.Locator("input[name='address1']");
            _cityInput = _page.Locator("input#city");
            _stateDropdown = _page.Locator("select#id_state");
            _postalCodeInput = _page.Locator("input#postcode");
            _mobileNumberInput = _page.Locator("input#phone_mobile");
            _registerButton = _page.Locator("button#submitAccount > span");
        }

        public async Task SelectTitle() => await _titleMrOption.ClickAsync();
        public async Task InputName(string name) => await _nameInput.TypeAsync(name);
        public async Task InputSurname(string surname) => await _surnameInput.TypeAsync(surname);
        public async Task InputPassword(string password) => await _passwordInput.TypeAsync(password);
        public async Task SelectBirthdayDay(string value) => await _birthdayDayDropdown.SelectOptionAsync(value);
        public async Task SelectBirthdayMonth(string value) => await _birthdayMonthDropdown.SelectOptionAsync(value);
        public async Task SelectBirthdayYear(string value) => await _birthdayYearDropdown.SelectOptionAsync(value);
        public async Task InputStreetAddress(string streetAddress) => await _streetAddressInput.TypeAsync(streetAddress);
        public async Task InputCity(string city) => await _cityInput.TypeAsync(city);
        public async Task SelectState(string value) => await _stateDropdown.SelectOptionAsync(value);
        public async Task InputPostalCode(string postalCode) => await _postalCodeInput.TypeAsync(postalCode);
        public async Task InputMobileNumber(string mobileNumber) => await _mobileNumberInput.TypeAsync(mobileNumber);
        public async Task ClickRegisterButton() => await _registerButton.ClickAsync();
    }
}
