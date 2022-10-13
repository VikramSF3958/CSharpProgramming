
namespace DictionaryDS
{
    public partial class Dictionary<TKey, TValue>
    {
        private int _count;
        private int _capacity;
        private TValue _value;

        public int Count { get { return _count; } }

        public int Capacity {set{ value = _capacity; } }

        private KeyValue<TKey, TValue> [] Array { get; set; }

        public Dictionary()
        {
            _count = 0;
            _capacity = 4;
            Array = new KeyValue<TKey, TValue>[_capacity];
        } 

        public Dictionary(int size)
        {
            _count = 0;
            _capacity = size;
            Array = new KeyValue<TKey, TValue>[_capacity];
        }

        public TValue this[TKey key]
        {   
            
            get { return get(key); }

            set 
            {
                _value = value;
                Update(key, _value);
            }
        }

        private TValue get(TKey Key)
        {   
            int index = 0;
            bool check  = true;
            for(int i=0; i<_count; i++)
            {
                if(Key.Equals(Array[i].Key))
                {
                    index = i;
                    check = false;
                    break;
                }
            }
            if(check)
            {
                System.Console.WriteLine("Key is not present");
                return default(TValue);
            }
            else
            {
                return Array[index].Value;
            }
        }
    
        private void Update(TKey Key, TValue value)
        {   
            bool check = true;
            for(int i=0; i<_count; i++)
            {
                if(Key.Equals(Array[i].Key))
                {
                    Array[i].Value = value;
                    check = false;
                    break;
                }
            }
            if(check)
            {
                System.Console.WriteLine("Invalid Key");
            }
        }
    }
}