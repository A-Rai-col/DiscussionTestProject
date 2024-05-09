using TestProject.Library;

namespace TestProject.Nunit.ConfigB;
[TestFixture]
internal class BTest2
{
	[SetUp]
	public void Setup()
	{
		TestContext.Progress.WriteLine("BTest2 Setup");

	}
	[TearDown]
	public void TearDown()
	{
		TestContext.Progress.WriteLine("BTest2 TearDown");
	}
	[Test]
	public void BTest2_Test1()
	{
		TestContext.Progress.WriteLine("BTest2_Test1");
		DemoDelay.WaitRandomTime();
		Assert.Fail();
	}
	[Test]
	public void BTest2_Test2()
	{
		TestContext.Progress.WriteLine("BTest2_Test2");
		DemoDelay.WaitRandomTime();
		Assert.Fail();
	}
	[Test]
	public void BTest2_Test3()
	{
		TestContext.Progress.WriteLine("BTest2_Test3");
		DemoDelay.WaitRandomTime();
		Assert.Pass();
	}
}
