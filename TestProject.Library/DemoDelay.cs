using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Library;
public static class DemoDelay
{
	public static void WaitRandomTime()
	{
		var milliseconds = Random.Shared.Next(500, 5000);
		Thread.Sleep(milliseconds);
	}
	public static void WaitFixedTime(int milliseconds)
	{
		Thread.Sleep(milliseconds);
	}
	public static async Task WaitRandomTimeAsync()
	{
		var milliseconds = Random.Shared.Next(500, 5000);
		await Task.Delay(milliseconds);
	}
	public static async Task WaitRandomTimeAsync(int start, int end)
	{
		var milliseconds = Random.Shared.Next(start, end);
		await Task.Delay(milliseconds);
	}
}
