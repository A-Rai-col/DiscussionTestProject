using TestProject.Library;

namespace TestProject.Nunit.ConfigC;
[TestFixture]
internal class CTest3
{
	[SetUp]
	public void Setup()
	{
		TestContext.Progress.WriteLine("CTest3 Setup");

	}
	[TearDown]
	public void TearDown()
	{
		TestContext.Progress.WriteLine("CTest3 TearDown");
	}
	[Test]
	public void CTest3_Test1()
	{
		TestContext.Progress.WriteLine("CTest3_Test1");
		DemoDelay.WaitRandomTime();
		Assert.Fail();
	}
	[Test]
	public void CTest3_Test2()
	{
		TestContext.Progress.WriteLine("CTest3_Test2");
		DemoDelay.WaitRandomTime();
		Assert.Fail();
	}
	[Test]
	public void CTest3_Test3()
	{
		TestContext.Progress.WriteLine("CTest3_Test3");
		DemoDelay.WaitRandomTime();
		Assert.Pass();
	}
}
