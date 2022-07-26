namespace tests.windows;

public class UiTestFixture : UiTestFixtureBase
{
    public const string WindowsApplication = "f0276ba8-3171-4a5d-9410-ac37ee234b34_9zz4h110yvjzm!App";// "com.companyname.app_7mzr475ysvhxg!App";
    public UiTestFixture() : base(
        new WindowsAppManagerOptions(WindowsApplication)
        {
            DriverUri = "http://127.0.0.1:4723",
            LaunchWinAppDriver = true,
            Maximize = true
        })
    {
        
    }
};