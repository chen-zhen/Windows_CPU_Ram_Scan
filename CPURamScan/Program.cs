using System;
using System.Diagnostics;
using System.Threading;

namespace CPURamScan
{
	class Program
	{
		static PerformanceCounter cpu = new PerformanceCounter("Processor", "% Processor Time", "_Total");
		static PerformanceCounter memory = new PerformanceCounter("Memory", "% Committed Bytes in Use");

		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("CPU: {0:n1}%", cpu.NextValue());
				Console.WriteLine("Memory: {0:n0}%", memory.NextValue());
				Thread.Sleep(1000);
			}
		}
	}
}
