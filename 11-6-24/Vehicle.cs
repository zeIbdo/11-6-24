namespace _11_6_24;

public abstract class Vehicle
{
    public string Color { get; set; }
    public int Year { get; set; }
    public abstract string ShowInfo();
    protected Vehicle(int year)
    {
        Year = year;
    }
}
