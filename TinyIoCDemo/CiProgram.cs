using System;
using TinyIoC;

namespace TinyIoCDemo
{
	public static class Bootstrap
	{
		public static void Register()
		{
			// This is a single instance registration.
			// When I ask the container for an IMessageService, is will always provide the same MessageService.
			TinyIoCContainer.Current.Register<IMessageService>(new MessageService());

			// This is a concrete type registration.
			// When I ask the container for one of these, it will build me one each time.
			TinyIoCContainer.Current.Register<MessagePrinter>();
		}
	}

	public class CiProgram
	{
		public static void Main(string[] args)
		{
			Bootstrap.Register();
			var messagePrinter = TinyIoCContainer.Current.Resolve<MessagePrinter>();
			messagePrinter.PrintMessage();
			Console.WriteLine("CI");
		}
	}
}