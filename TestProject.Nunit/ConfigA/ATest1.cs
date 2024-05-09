using TestProject.Library;

namespace TestProject.Nunit.ConfigA;


[TestFixture]
internal class ATest1
{
	[SetUp]
	public void Setup()
	{
		TestContext.Progress.WriteLine("ATest1 Setup");

	}
	[TearDown]
	public void TearDown()
	{
		TestContext.Progress.WriteLine("ATest1 TearDown");
	}
	[Test]
	public void ATest1_Test1()
	{
		TestContext.Progress.WriteLine("ATest1_Test1");
		DemoDelay.WaitRandomTime();
		Assert.Fail();
	}
	[Test]
	public void ATest1_Test2()
	{
		TestContext.Progress.WriteLine("ATest1_Test2");
		DemoDelay.WaitRandomTime();
		Assert.Fail();
	}
	[Test]
	public void ATest1_Test3()
	{
		TestContext.Progress.WriteLine("ATest1_Test3");
		DemoDelay.WaitRandomTime();
		Assert.Pass();
	}
}
