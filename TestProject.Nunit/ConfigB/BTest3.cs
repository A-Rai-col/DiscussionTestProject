using TestProject.Library;

namespace TestProject.Nunit.ConfigB;
[TestFixture]
internal class BTest3
{
	[SetUp]
	public void Setup()
	{
		TestContext.Progress.WriteLine("BTest3 Setup");

	}
	[TearDown]
	public void TearDown()
	{
		TestContext.Progress.WriteLine("BTest3 TearDown");
	}
	[Test]
	public void BTest3_Test1()
	{
		TestContext.Progress.WriteLine("BTest3_Test1");
		DemoDelay.WaitRandomTime();
		Assert.Fail();
	}
	[Test]
	public void BTest3_Test2()
	{
		TestContext.Progress.WriteLine("BTest3_Test2");
		DemoDelay.WaitRandomTime();
		Assert.Fail();
	}
	[Test]
	public void BTest3_Test3()
	{
		TestContext.Progress.WriteLine("BTest3_Test3");
		DemoDelay.WaitRandomTime();
		Assert.Pass();
	}
}
