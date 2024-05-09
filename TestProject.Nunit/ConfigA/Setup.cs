using TestProject.Library;

namespace TestProject.Nunit.ConfigA;
[Parallelizable(ParallelScope.Children)]
[SetUpFixture]
internal class Setup()
{

	[OneTimeSetUp]
	public void OTSetup()
	{
		TestContext.Progress.WriteLine("ConfigA.Setup.OTSetup - Start setup");

		DemoDelay.WaitFixedTime(4000);

		TestContext.Progress.WriteLine("ConfigA.Setup.OTSetup - Finished Setup");
	}
	[OneTimeTearDown]
	public void OTTearDown()
	{
		TestContext.Progress.WriteLine("ConfigA.Setup.OTTearDown");
	}
}