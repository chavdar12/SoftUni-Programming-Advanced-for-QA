using System.Text;

namespace TestApp.Chat;

public class ChatRoom
{
    private readonly List<ChatMessage> _chatMessages = new();

    public void SendMessage(string sender, string message)
    {
        _chatMessages.Add(new ChatMessage(sender, message));
    }

    public string DisplayChat()
    {
        if (_chatMessages.Count == 0) return string.Empty;

        StringBuilder sb = new();
        sb.AppendLine("Chat Room Messages:");
        foreach (var message in _chatMessages)
            sb.AppendLine($"{message.Sender}: {message.Message} - Sent at {message.Timestamp}");

        return sb.ToString().Trim();
    }
}
