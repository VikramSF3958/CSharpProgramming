
namespace DictionaryDS
{
    public partial class Dictionary<TKey, TValue>
    {
        public void Add(TKey Key, TValue value)
        {
            if(_count == _capacity)
            {
                //Call GrowSize() Method
                GrowSize();
            }

            if(LinearSearch(Key))
            {
                System.Console.WriteLine($"Key '{Key}' Already Exists\nIdentical Keys are not allowed");
            }
            else
            {
                KeyValue<TKey, TValue> obj = new KeyValue<TKey, TValue>();
                obj.Key = Key;
                obj.Value = value;
                Array[_count] = obj;
                _count++;
            }
        }

        private void GrowSize()
        {   
            int tempSize = _capacity;
            _capacity = _capacity * 2;

           KeyValue<TKey, TValue>[] temp = new KeyValue<TKey, TValue>[_capacity]; 

            for(int i=0; i<_count; i++)
            {
                temp[i] = Array[i];
            }

            Array = temp;

        }

        private bool  LinearSearch(TKey key)
        {
            bool check = false;

            for(int i=0; i<_count; i++)
            {
                if(key.Equals(Array[i].Key))
                {
                    check = true;
                    break;
                }
            }

            return check;

        }
    
    }
}