namespace tests;

public class UiTestFixture : UiTestFixtureBase
{
    public const string IOSApplication = "com.companyname.app";
    public UiTestFixture() : base(
        new IOSAppManagerOptions
        {
            AppId = IOSApplication,
            DeviceName = "iPhone SE (3rd generation) Simulator",
            DeviceId = "56755E6F-741B-478F-BB1B-A48E05ACFE8A",
            OSVersion = "15.4",
            LaunchAppiumServer = true,
            DriverUri = "http://localhost:4723/wd/hub"
        })
    {
    }
}