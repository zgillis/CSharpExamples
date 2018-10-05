using System;
using System.IO;
using System.Threading.Tasks;

namespace CSLearn1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("---PROGRAM STARTED---");
			DoAsyncStuff ();
			for(int i = 0; i < 10; i++) {
				Console.WriteLine("[MAIN]: " + i);
				System.Threading.Thread.Sleep(500);
			}
		}

		public static async Task DoAsyncStuff()
		{
			await Task.Run (() => {
				for(int i = 0; i < 10; i++) {
					Console.WriteLine("[DoAsyncStuff]: " + i);
					System.Threading.Thread.Sleep(500);
				}
			});
		}
	}
}
