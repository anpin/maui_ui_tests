using Legerity.Pages;
using OpenQA.Selenium.Remote;

namespace tests;

public class MainPage : MainPageBase
{
    protected override By GetBy(string id) => By.Id(id);

    protected override IWebElement GetElement(string id) => FindElement(By.Id(id));
}

public class WinMainPage : MainPageBase
{
    
    protected override By GetBy(string id) => WindowsByExtras.AutomationId(id);
    protected override IWebElement GetElement(string id) => this.WindowsApp.FindElement(GetBy(id));
}
public abstract class MainPageBase : BasePage
{

    protected override By Trait => GetBy("MainPage");
    public IWebElement Button => GetElement("button");
    protected abstract By GetBy(string id);
    protected abstract IWebElement GetElement(string id) ;
}

public abstract class MainPageTest<F> : IClassFixture<F>
where F : UiTestFixtureBase
{
    UiTestFixtureBase _fixture;
    protected  abstract MainPageBase _page { get; } // = new MainPage();
    public MainPageTest(UiTestFixtureBase fixture) => _fixture = fixture;
    [Fact]
         public void TestButton()
         {
             
             Assert.Equal( "Click me", _page.Button.Text);
             
             _page.Button.Click();
             Assert.Equal( "Clicked 1 time", _page.Button.Text);
             for (var i = 2; i < 4; ++i)
             {
                 _page.Button.Click();
                 Assert.Equal($"Clicked {i} times", _page.Button.Text);
             }
         }
}
