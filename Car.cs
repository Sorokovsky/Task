namespace Task
{
    internal class Car : Vehicle
    {
        private int _fuelMax = 0;

        public string Mark {  get; set; } = string.Empty;
        public int FuelMax
        {
            get
            {
                return _fuelMax;
            }
            set
            {
                if(value < 0)
                {
                    _fuelMax = 0;
                }
                else
                {
                    _fuelMax = value;
                }
            }
        }

        public Car(string name, int speed, string mark, int fuelMax) : base(name, speed)
        {
            Mark = mark;
            FuelMax = fuelMax;
        }

        public Car(Vehicle vehicle, string mark, int fuelMax) : this(vehicle.Name, vehicle.Speed, mark, fuelMax)
        {
        }

        public Car() : base()
        {
            
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Марка машини: {0}.", Mark);
            Console.WriteLine("Максимальна кількість палива (л.): {0}.", FuelMax);
        }
    }
}
