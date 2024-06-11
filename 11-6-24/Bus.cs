namespace _11_6_24;

public class Bus: Vehicle
{
    public int PassengerCount { get; set; }
    public Bus(int year, int pascount):base(year)
    {
        PassengerCount = pascount;
    }
    public override string ShowInfo()
    {
        return $"{Year} {PassengerCount}";
    }
}
