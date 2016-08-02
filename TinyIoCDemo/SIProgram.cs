using System;
using TinyIoC;

namespace TinyIoCDemo
{
	public class SiProgram
	{
		public static void Main1(string[] args)
		{
			Bootstrap.Register();

			var coolMessagePrinter = new CoolMessagePrinter();
			TinyIoCContainer.Current.BuildUp(coolMessagePrinter);

			coolMessagePrinter.PrintMessage();
			Console.WriteLine("SI");
		}
	}
}