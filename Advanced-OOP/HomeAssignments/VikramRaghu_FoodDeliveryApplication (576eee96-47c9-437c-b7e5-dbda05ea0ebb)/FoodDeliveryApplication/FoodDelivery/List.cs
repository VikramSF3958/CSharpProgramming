
namespace FoodDelivery
{
    public partial class List<Type>
    {
        private Type [] Array { get; set; }

        private int _count;

        private int _capacity;

        public int Count { get{return _count;} }

        public int Capacity { get{return _capacity; } }

        //Indexer
        public Type this[int i]
        {
            get{ return Array[i]; }
            set { Array[i] = value; }
        }

        //Create a constructor that initializes the values
        public List()
        {
            _count = 0;
            _capacity = 4;
            Array = new Type [_capacity];
        }

        public List(int size)
        {
            _count = 0;
            _capacity = size;
            Array = new Type[_capacity];
        }

        //Creating an Add to append data to list
        public void Add(Type data)
        {   
            //compares if _count and _capacity is same, if both are same,  increase the capacity to allow to add to list
            if(_count == _capacity)
            {
                //call GrowSize() method that creates an array of double size

                GrowSize();
            }

            Array[_count] = data;
            _count++;
            
        }

        public void GrowSize()
        {   
            int tempSize = _capacity;
            _capacity = _capacity * 2;

            Type[] temp = new Type[_capacity];

            for(int i=0; i<tempSize; i++)
            {
                temp[i] = Array[i];
            }

            Array = temp;

        }

        public void ShowList()
        {
            foreach(var element in Array)
            {
                System.Console.Write($"{element} ");
            }
        }

        public Type OfIndex(int index)
        {
            return Array[index];
        }
        
    }
}