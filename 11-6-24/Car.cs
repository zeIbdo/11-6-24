namespace _11_6_24;

public class Car: Vehicle
{
    public int MaxSpeed { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public Car(int year,string brand,string model):base(year)
    {
        Brand = brand;
        Model = model;
    }
    public override string ShowInfo()
    {
        return $"{Year} {Brand} {Model} ";
    }
}
