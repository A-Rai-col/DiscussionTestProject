using TestProject.Library;

namespace TestProject.Nunit.ConfigC;
[Parallelizable(ParallelScope.Children)]
[SetUpFixture]
internal class Setup()
{

	[OneTimeSetUp]
	public void OTSetup()
	{
		TestContext.Progress.WriteLine("ConfigC.Setup.OTSetup - Start setup");

		DemoDelay.WaitFixedTime(4000);

		TestContext.Progress.WriteLine("ConfigC.Setup.OTSetup - Finished Setup");
	}
	[OneTimeTearDown]
	public void OTTearDown()
	{
		TestContext.Progress.WriteLine("ConfigC.Setup.OTTearDown");
	}
}