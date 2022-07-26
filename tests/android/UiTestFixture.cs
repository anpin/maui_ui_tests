namespace tests.android;

public class UiTestFixture : UiTestFixtureBase
{

    public const string AndroidApplication = "com.companyname.app";

    public const string AndroidApplicationActivity = $"{AndroidApplication}.MainActivity";
    static AppiumOptions? _appiumOptions = null;
    static AppiumOptions AppiumOptions
    {
        get
        {
            if (_appiumOptions == null)
            {
                _appiumOptions = new AppiumOptions();
                _appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Moto_G5_Plus__XT1685_");
                _appiumOptions.AddAdditionalCapability(MobileCapabilityType.Udid, "ZY2247KNS6");
                _appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
                _appiumOptions.AddAdditionalCapability(AndroidMobileCapabilityType.AppPackage, "com.companyname.app");
                _appiumOptions.AddAdditionalCapability(AndroidMobileCapabilityType.AppActivity, "crc6492a0fe1559608a27.MainActivity");
                _appiumOptions.AddAdditionalCapability(AndroidMobileCapabilityType.AppWaitDuration, 10000);
            }
            return _appiumOptions;
        }
    }

    static string slnRoot =>
        Path.GetRelativePath(Environment.CurrentDirectory,  string.Concat(Enumerable.Repeat($"..{Path.DirectorySeparatorChar}", 4)));
    static string appPath => Path.GetFullPath(Path.Combine(
        slnRoot,
        "app",
        "bin",
        "Debug", 
        "net6.0-android",
        $"{AndroidApplication}.apk"));
    public UiTestFixture() : base(
        new AndroidAppManagerOptions(appPath)
        {
            DriverUri = "http://127.0.0.1:4723/wd/hub",
            LaunchAppiumServer = true,
            AppiumOptions = AppiumOptions,
        })
    {
    }
}