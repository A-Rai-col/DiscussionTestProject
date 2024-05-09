using TestProject.Library;

namespace TestProject.Nunit.ConfigA;
[TestFixture]
internal class ATest2
{
	[SetUp]
	public void Setup()
	{
		TestContext.Progress.WriteLine("ATest2 Setup");

	}
	[TearDown]
	public void TearDown()
	{
		TestContext.Progress.WriteLine("ATest2 TearDown");
	}
	[Test]
	public void ATest2_Test1()
	{
		TestContext.Progress.WriteLine("ATest2_Test1");
		DemoDelay.WaitRandomTime();
		Assert.Fail();
	}
	[Test]
	public void ATest2_Test2()
	{
		TestContext.Progress.WriteLine("ATest2_Test2");
		DemoDelay.WaitRandomTime();
		Assert.Fail();
	}
	[Test]
	public void ATest2_Test3()
	{
		TestContext.Progress.WriteLine("ATest2_Test3");
		DemoDelay.WaitRandomTime();
		Assert.Pass();
	}
}
