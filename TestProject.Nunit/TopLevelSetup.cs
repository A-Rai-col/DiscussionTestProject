using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TestProject.Nunit;


[Parallelizable(ParallelScope.Fixtures)]
[SetUpFixture]
internal class TopLevelSetup
{
#pragma warning disable NUnit1032 // An IDisposable field/property should be Disposed in a TearDown method
	private static IServiceProvider _serviceProvider;
#pragma warning restore NUnit1032 // An IDisposable field/property should be Disposed in a TearDown method

	[OneTimeSetUp]
	public void OTSetup()
	{
		var services = new ServiceCollection();
		IConfiguration configuration = new ConfigurationBuilder()
			.SetBasePath(Directory.GetCurrentDirectory())
			.AddJsonFile("appsettings.development.json", optional: true, reloadOnChange: true)
			.Build();

		services.AddSingleton(typeof(IConfiguration), configuration);
		_serviceProvider = services.BuildServiceProvider();
		TestContext.Progress.WriteLine("TopLevelSetup.OTSetup");
	}
	[OneTimeTearDown]
	public void OTTearDown()
	{
		(_serviceProvider as IDisposable)?.Dispose();
		TestContext.Progress.WriteLine("TopLevelSetup.OTTearDown");
	}
}
