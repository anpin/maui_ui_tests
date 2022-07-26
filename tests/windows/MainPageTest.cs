namespace tests.windows;

public class MainPageTest : MainPageTest<UiTestFixture>
{
    public MainPageTest(UiTestFixture fixtureBase) : base(fixtureBase)
    {
    }
    
    protected override MainPageBase _page { get; } = new WinMainPage();
}