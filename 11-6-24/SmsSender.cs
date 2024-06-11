namespace _11_6_24;

internal class SmsSender:MessageSender
{
    public override void SendMessage()
    {
        Console.Write("Send message by SMS:");
        string output = Console.ReadLine();
        Console.WriteLine("Message delivered");
    }
}
