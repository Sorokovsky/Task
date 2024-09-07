//Variant 11

namespace Task;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Введення транспортного засобу.");
        Vehicle vehicle = EnterVehicle();
        Console.WriteLine("Введення автомобілю.");
        Car car = EnterCar();
        Console.WriteLine("Введення поїзда.");
        Train train = EnterTrain();
        Console.WriteLine("Введення експресу.");
        Express express = EnterExpress();
        Console.WriteLine("Транспортний засіб.");
        vehicle.Show();
        Console.WriteLine("Автомобіль.");
        car.Show();
        Console.WriteLine("Поїзд.");
        train.Show();
        Console.WriteLine("Експрес.");
        express.Show();
    }

    public static Vehicle EnterVehicle()
    {
        string name;
        int speed;
        Console.WriteLine("Введіть ім'я: "); name = Console.ReadLine();
        Console.WriteLine("Введіть швидкість: "); speed = Convert.ToInt32(Console.ReadLine());
        return new Vehicle(name, speed);
    }

    public static Car EnterCar()
    {
        string mark;
        int fuelMax;
        Console.WriteLine("Введіть бренд: "); mark = Console.ReadLine();
        Console.WriteLine("Введіть максимальну кількість палива: "); fuelMax = Convert.ToInt32(Console.ReadLine());
        Vehicle vehicle = EnterVehicle();
        return new Car(vehicle, mark, fuelMax);
    }

    public static Train EnterTrain()
    {
        int carriageCount;
        Console.WriteLine("Введіть кількість: "); carriageCount = Convert.ToInt32(Console.ReadLine());
        Vehicle vehicle = EnterVehicle();
        return new Train(vehicle, carriageCount);
    }

    public static Express EnterExpress()
    {
        string benefits;
        Console.WriteLine("Введіть переваги: "); benefits = Console.ReadLine();
        Train train = EnterTrain();
        return new Express(train, benefits);
    }
}