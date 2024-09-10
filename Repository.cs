namespace Task
{
    public class Repository<T> where T : Vehicle
    {
        private LinkedList<T> _list = new();

        public void Append(T item) 
        {
            _list.AddLast(item);
        }

        public IEnumerable<T> GetByName(string name)
        {
            return _list.Where(x => x.Name.Equals(name));
        }

        public void DeleteByName(string name)
        {
            var selected = GetByName(name);
            foreach(T item in selected)
            {
                _list.Remove(item);
                break;
            }
        }

        public IEnumerable<T> GetAll() {
            return _list.Where(x => true);
        }
    }
}