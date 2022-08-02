using Microsoft.Playwright.NUnit;
using PlaywrightAutomation.AutomationPractice.Pages;

namespace PlaywrightAutomation.AutomationPractice;

[Parallelizable(ParallelScope.Self)]
public class Tests : PageTest
{
    HomePage homePage;
    AccountPage accountPage;
    CreateAccountPage createAccountPage;

    private Bogus.Faker _faker = new Bogus.Faker();

    [SetUp]
    async public Task Setup()
    {
        await Page.GotoAsync("http://automationpractice.com/index.php");

        homePage = new HomePage(Page);
        accountPage = new AccountPage(Page);
        createAccountPage = new CreateAccountPage(Page);
    }

    [Test]
    async public Task CheckPageTitle()
    {
        await Expect(Page).ToHaveTitleAsync("My Store");
    }

    [Test]
    async public Task CreateAccount()
    {
        await homePage.ClickSignInButton();

        await accountPage.InputEmail($"{Guid.NewGuid()}@test.com");
        await accountPage.ClickCreateAccountButton();

        await createAccountPage.SelectTitle();
        await createAccountPage.InputName(_faker.Name.FirstName());
        await createAccountPage.InputSurname(_faker.Name.LastName());
        await createAccountPage.InputPassword(Guid.NewGuid().ToString());
        await createAccountPage.SelectBirthdayDay("12");
        await createAccountPage.SelectBirthdayMonth("12");
        await createAccountPage.SelectBirthdayYear("1990");
        await createAccountPage.InputStreetAddress(_faker.Address.StreetAddress());
        await createAccountPage.InputCity(_faker.Address.City());
        await createAccountPage.SelectState("43");
        await createAccountPage.InputPostalCode(_faker.Address.ZipCode());
        await createAccountPage.InputMobileNumber(_faker.Phone.PhoneNumber());
        await createAccountPage.ClickRegisterButton();
    }
}