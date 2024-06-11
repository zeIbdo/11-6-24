namespace _11_6_24;

internal class Program
{
    static void Main(string[] args)
    {
        // int num = 5;
        // SmsSender smsSender = new();
        // EmailSender emailSender = new();
        // Console.WriteLine("if you want send message by sms enter 2");
        // Console.WriteLine("if you want send message by email enter 1");
        // Console.WriteLine("if you want to quit enter 0");
        //// Ibrahim:
        // while (num != 0)
        // {
        //  num =Convert.ToInt32( Console.ReadLine());
        //     if (num == 1)
        //     {
        //         emailSender.SendMessage();
        //        // goto Ibrahim;
        //     }
        //     if (num == 2)
        //     {
        //         smsSender.SendMessage();
        //        // goto Ibrahim;
        //     }
        // }
        Vehicle[] vehicles = new Vehicle[] {
         new Car(1945, "Ford", "Mustang"),
         new Car(1989, "Dodge", "Challenger"),
         new Bus(1978, 190),
         new Bus(1988, 200),
        };
        foreach(Vehicle item in vehicles)
        {
            Console.WriteLine( item.ShowInfo());
        }
    }
}
