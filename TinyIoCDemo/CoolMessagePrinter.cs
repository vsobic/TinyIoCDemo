using System;

namespace TinyIoCDemo
{
	public class CoolMessagePrinter
	{
		public IMessageService MessageService { get; set; }

		public void PrintMessage()
		{
			Console.WriteLine(MessageService.GetMessage());
		}
	}
}