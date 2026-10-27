using TestApp.Chat;

namespace Tests;

public class ChatRoomTests
{
    private ChatRoom _chatRoom = null!;

    [SetUp]
    public void SetUp()
    {
        _chatRoom = new ChatRoom();
    }

    [Test]
    public void Test_SendMessage_MessageSentToChatRoom()
    {
        _chatRoom.SendMessage("John", "Hello");

        Assert.That(_chatRoom.DisplayChat(), Is.EqualTo(
            $"Chat Room Messages:{Environment.NewLine}John: Hello - Sent at {DateTime.Now.Date:d}"));
    }

    [Test]
    public void Test_DisplayChat_NoMessages_ReturnsEmptyString()
    {
        Assert.That(_chatRoom.DisplayChat(), Is.Empty);
    }

    [Test]
    public void Test_DisplayChat_WithMessages_ReturnsFormattedChat()
    {
        _chatRoom.SendMessage("John", "Hello");
        _chatRoom.SendMessage("Jane", "Hi John!");

        var lines = _chatRoom.DisplayChat().Split(Environment.NewLine);

        Assert.That(lines, Has.Length.EqualTo(3));
        Assert.That(lines[0], Is.EqualTo("Chat Room Messages:"));
        Assert.That(lines[1], Does.StartWith("John: Hello - Sent at "));
        Assert.That(lines[2], Does.StartWith("Jane: Hi John! - Sent at "));
    }
}
