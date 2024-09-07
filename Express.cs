namespace Task
{
    public class Express : Train
    {
        public string Benefits { get; set; } = string.Empty;

        public Express() : base()
        {
            
        }

        public Express(string name, int speed, int carriagesCount, string benefits) : base(name, speed, carriagesCount)
        {
            Benefits = benefits;
        }

        public Express(Train train, string benefits) : this(train.Name, train.Speed, train.CarriagesCount, benefits) 
        {
            
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Переваги: {0}.", Benefits);
        }
    }
}
