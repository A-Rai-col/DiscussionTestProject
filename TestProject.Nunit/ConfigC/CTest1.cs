using TestProject.Library;

namespace TestProject.Nunit.ConfigC;
[TestFixture]
internal class CTest1
{
	[SetUp]
	public void Setup()
	{
		TestContext.Progress.WriteLine("CTest1 Setup");

	}
	[TearDown]
	public void TearDown()
	{
		TestContext.Progress.WriteLine("CTest1 TearDown");
	}
	[Test]
	public void CTest1_Test1()
	{
		TestContext.Progress.WriteLine("CTest1_Test1");
		DemoDelay.WaitRandomTime();
		Assert.Fail();
	}
	[Test]
	public void CTest1_Test2()
	{
		TestContext.Progress.WriteLine("CTest1_Test2");
		DemoDelay.WaitRandomTime();
		Assert.Fail();
	}
	[Test]
	public void CTest1_Test3()
	{
		TestContext.Progress.WriteLine("CTest1_Test3");
		DemoDelay.WaitRandomTime();
		Assert.Pass();
	}
}
