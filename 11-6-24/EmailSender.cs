namespace _11_6_24;

internal class EmailSender:MessageSender
{
    public override void SendMessage()
    {
        Console.Write("Send message by Email:");
       string output= Console.ReadLine();
        Console.WriteLine("Message delivered");
    }
}
