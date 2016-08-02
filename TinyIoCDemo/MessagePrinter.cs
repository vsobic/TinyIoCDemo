using System;

namespace TinyIoCDemo
{
	public class MessagePrinter
	{
		private readonly IMessageService _messageService;

		public MessagePrinter(IMessageService messageService)
		{
			_messageService = messageService;
		}

		public void PrintMessage()
		{
			Console.WriteLine(_messageService.GetMessage());
		}
	}
}