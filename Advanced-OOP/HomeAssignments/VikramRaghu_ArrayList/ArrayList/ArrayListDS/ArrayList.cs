
namespace ArrayListDS
{
    public partial class ArrayList
    {       
        //Dynamic is a data-type
        private dynamic [] Array { get; set; }

        private int _count;

        private int _capacity;

        public int Count { get{ return _count; } }

        public dynamic this[int i]
        {
            get{ return Array[i]; }
            set { Array[i] = value; }
        }

        public ArrayList()
        {
            _count = 0;
            _capacity = 4;
            Array = new dynamic [_capacity];
        }

        public ArrayList(int size)
        {
            _count = 0;
            _capacity = size;
            Array = new dynamic [_capacity];
        }
    }
}