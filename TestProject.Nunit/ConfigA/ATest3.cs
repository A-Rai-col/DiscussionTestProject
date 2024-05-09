using TestProject.Library;

namespace TestProject.Nunit.ConfigA;
[TestFixture]
internal class ATest3
{
	[SetUp]
	public void Setup()
	{
		TestContext.Progress.WriteLine("ATest3 Setup");

	}
	[TearDown]
	public void TearDown()
	{
		TestContext.Progress.WriteLine("ATest3 TearDown");
	}
	[Test]
	public void ATest3_Test1()
	{
		TestContext.Progress.WriteLine("ATest3_Test1");
		DemoDelay.WaitRandomTime();
		Assert.Fail();
	}
	[Test]
	public void ATest3_Test2()
	{
		TestContext.Progress.WriteLine("ATest3_Test2");
		DemoDelay.WaitRandomTime();
		Assert.Fail();
	}
	[Test]
	public void ATest3_Test3()
	{
		TestContext.Progress.WriteLine("ATest3_Test3");
		DemoDelay.WaitRandomTime();
		Assert.Pass();
	}
}
