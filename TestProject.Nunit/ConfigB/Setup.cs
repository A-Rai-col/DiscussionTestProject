using TestProject.Library;

namespace TestProject.Nunit.ConfigB;
[Parallelizable(ParallelScope.Children)]
[SetUpFixture]
internal class Setup()
{

	[OneTimeSetUp]
	public void OTSetup()
	{
		TestContext.Progress.WriteLine("ConfigB.Setup.OTSetup - Start setup");

		DemoDelay.WaitFixedTime(4000);

		TestContext.Progress.WriteLine("ConfigB.Setup.OTSetup - Finished Setup");
	}
	[OneTimeTearDown]
	public void OTTearDown()
	{
		TestContext.Progress.WriteLine("ConfigB.Setup.OTTearDown");
	}
}