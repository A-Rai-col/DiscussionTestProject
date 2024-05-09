using TestProject.Library;

namespace TestProject.Nunit.ConfigC;
[TestFixture]
internal class CTest2
{
	[SetUp]
	public void Setup()
	{
		TestContext.Progress.WriteLine("CTest2 Setup");

	}
	[TearDown]
	public void TearDown()
	{
		TestContext.Progress.WriteLine("CTest2 TearDown");
	}
	[Test]
	public void CTest2_Test1()
	{
		TestContext.Progress.WriteLine("CTest2_Test1");
		DemoDelay.WaitRandomTime();
		Assert.Fail();
	}
	[Test]
	public void CTest2_Test2()
	{
		TestContext.Progress.WriteLine("CTest2_Test2");
		DemoDelay.WaitRandomTime();
		Assert.Fail();
	}
	[Test]
	public void CTest2_Test3()
	{
		TestContext.Progress.WriteLine("CTest2_Test3");
		DemoDelay.WaitRandomTime();
		Assert.Pass();
	}
}
