namespace tests;

public abstract class UiTestFixtureBase: LegerityTestClass, IDisposable
    {
        public UiTestFixtureBase(AppManagerOptions options) : base(options)
        {
            this.StartApp();


        }

        public void Dispose()
        {
            this.StopApp();
        }
	
    }



