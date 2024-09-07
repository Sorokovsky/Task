namespace Task
{
    public class Vehicle
    {
        private int _speed = 0;

        public string Name { get; set; } = string.Empty;
        public int Speed 
        {
            get
            {
                return _speed;
            } 
            set
            {
                if(value < 0)
                {
                    _speed = 0;
                }
                else
                {
                    _speed = value;
                }
            }
        }

        public Vehicle()
        {
            
        }

        public Vehicle(string name, int speed)
        {
            Speed = speed;
            Name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("Ім'я: {0}.", Name);
            Console.WriteLine("Швидкість: {0}.", Speed);
        }
    }
}
