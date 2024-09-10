//Variant 11

namespace Task;

public static class Program
{
    private static Repository<Vehicle> vehicles = new();
    private static Repository<Vehicle> cars = new();
    private static Repository<Vehicle> trains = new();
    private static Repository<Vehicle> express = new();

    public static void Main()
    {
        while(true) 
        {
            Repository<Vehicle> currentRepository = ChooseVehicleType();
            if(currentRepository == null) {
                continue;
            }
            int operation = ChooseOperation();
            switch(operation)
            {
                case 0:
                {
                    return;
                }
                case 1: {
                    if(currentRepository == vehicles) currentRepository.Append(EnterVehicle());
                    else if(currentRepository == cars) currentRepository.Append(EnterCar());
                    else if(currentRepository == trains) currentRepository.Append(EnterTrain());
                    else if(currentRepository == express) currentRepository.Append(EnterExpress());
                    else currentRepository.Append(EnterVehicle());
                    break; 
                }
                case 2: {
                    Console.WriteLine("Введіть імя для видалення: ");
                    string name = Console.ReadLine();
                    currentRepository.DeleteByName(name);
                    break;
                }
                case 3: {
                    Console.WriteLine("Введіть імя для пошуку: ");
                    string name = Console.ReadLine();
                    var items = currentRepository.GetByName(name);
                    for(int i = 0; i < items.Count(); i++) {
                        Console.WriteLine("#{0}", i + 1);
                        items.ElementAt(i).Show();
                    }
                    break;
                }
                case 4: {
                    var items = currentRepository.GetAll();
                    for(int i = 0; i < items.Count(); i++) {
                        Console.WriteLine("#{0}", i + 1);
                        items.ElementAt(i).Show();
                    }
                    break;
                }
                default: {
                    Console.WriteLine("Непередбачуваний вибір.");
                    break;
                }
            }
        }
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
        Console.WriteLine("Введіть кількість вагонів: "); carriageCount = Convert.ToInt32(Console.ReadLine());
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

    public static int ChooseOperation() 
    {
        Console.WriteLine("Оберіть операцію.");
        Console.WriteLine("0-Вийти.");
        Console.WriteLine("1-Додати.");
        Console.WriteLine("2-Видалити.");
        Console.WriteLine("3-Знайти за іменем.");
        Console.WriteLine("4-Показати все.");
        Console.Write(">> ");
        return Convert.ToInt32(Console.ReadLine());   
    }

    public static Repository<Vehicle> ChooseVehicleType()
    {
        Console.WriteLine("Виберіть з чим хочете працювати: ");
        Console.WriteLine("1-Транспортний засіб.");
        Console.WriteLine("2-Автомобіль.");
        Console.WriteLine("3-Поїзд.");
        Console.WriteLine("4-Експрес.");
        int repoNumber = Convert.ToInt32(Console.ReadLine());
        switch(repoNumber)
            {
                case 1:
                {
                    return vehicles;
                }
                case 2:
                {
                    return cars;
                }
                case 3:
                {
                    return trains;
                }
                case 4:
                {
                    return express;
                }
                default:
                {
                    Console.WriteLine("Непередбачуваний вибір. Повторіть");
                    return null;
                }
            }
    }
}