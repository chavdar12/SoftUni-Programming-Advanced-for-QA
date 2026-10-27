namespace TestApp.Chat;

public class ChatMessage
{
    public ChatMessage(string sender, string message)
    {
        Sender = sender;
        Message = message;
        Timestamp = DateTime.Now.Date.ToString("d");
    }

    public string Sender { get; }

    public string Message { get; }

    public string Timestamp { get; }
}
