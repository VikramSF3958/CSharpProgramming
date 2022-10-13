
namespace DictionaryDS
{
    public partial class Dictionary<TKey, TValue>
    {
        public bool ContainsKey(TKey key)
        {
            for(int i=0; i<_count; i++)
            {
                if(key.Equals(Array[i].Key))
                {
                    return true;
                }
            }

            return false;
        }
    
        public bool ContainsValue(TValue  value)
        {
            for(int i=0; i<_count; i++)
            {
                if(value.Equals(Array[i].Value))
                {
                    return true;
                }
            }

            return false;
        }

        public bool TryGetValue(TKey Key, out TValue value)
        {
            for(int i=0; i<_count; i++)
            {
                if(Key.Equals(Array[i].Key))
                {   
                    value = Array[i].Value;
                    return true;
                }
            }
            value = default(TValue);
            return false;
        }

        public KeyValue<TKey, TValue> ElementAt(int position)
        {
            for(int i=0; i<_count; i++)
            {
                if(position == (i+1))
                {
                    return Array[i];
                }
            }

            return default(KeyValue<TKey, TValue>);
        }
    }
}