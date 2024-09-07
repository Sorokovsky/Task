namespace Task
{
    public class Train : Vehicle
    {
        private int _carriagesCount = 0;
        public int CarriagesCount
        {
            get
            {
                return _carriagesCount;
            }
            set
            {
                if(value < 0)
                {
                    _carriagesCount = 0;
                }
                else
                {
                    _carriagesCount = value;
                }
            }
        }

        public Train() : base()
        {
            
        }

        public Train(string name, int speed, int carriagesCount) : base(name, speed)
        {
            CarriagesCount = carriagesCount;
        }

        public Train(Vehicle vehicle, int carriagesCount) : this(vehicle.Name, vehicle.Speed, carriagesCount)
        {
            
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Кількість вагонів: {0}.", CarriagesCount);
        }
    }
}
