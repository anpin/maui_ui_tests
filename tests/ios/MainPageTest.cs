namespace tests.ios;

public class MainPageTest : MainPageTest<UiTestFixture>
{
    public MainPageTest(UiTestFixture fixture) : base(fixture)
    {
    }

    protected override MainPage _page { get; } = new();
}