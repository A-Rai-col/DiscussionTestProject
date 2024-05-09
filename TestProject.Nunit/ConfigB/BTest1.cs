using TestProject.Library;

namespace TestProject.Nunit.ConfigB;
[TestFixture]
internal class BTest1
{
	[SetUp]
	public void Setup()
	{
		TestContext.Progress.WriteLine("BTest1 Setup");

	}
	[TearDown]
	public void TearDown()
	{
		TestContext.Progress.WriteLine("BTest1 TearDown");
	}
	[Test]
	public void BTest1_Test1()
	{
		TestContext.Progress.WriteLine("BTest1_Test1");
		DemoDelay.WaitRandomTime();
		Assert.Fail();
	}
	[Test]
	public void BTest1_Test2()
	{
		TestContext.Progress.WriteLine("BTest1_Test2");
		DemoDelay.WaitRandomTime();
		Assert.Fail();
	}
	[Test]
	public void BTest1_Test3()
	{
		TestContext.Progress.WriteLine("BTest1_Test3");
		DemoDelay.WaitRandomTime();
		Assert.Pass();
	}
}
