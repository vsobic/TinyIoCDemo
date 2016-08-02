namespace TinyIoCDemo
{
	public class MessageService : IMessageService
	{
		public string GetMessage()
		{
			return "Hello World!";
		}
	}
}