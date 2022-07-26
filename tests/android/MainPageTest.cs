namespace tests.android;

public class MainPageTest : MainPageTest<UiTestFixture>
{
    
    public MainPageTest(UiTestFixture fixtureBase) : base(fixtureBase)
    {
    }

    protected override MainPage _page { get; } = new();
}