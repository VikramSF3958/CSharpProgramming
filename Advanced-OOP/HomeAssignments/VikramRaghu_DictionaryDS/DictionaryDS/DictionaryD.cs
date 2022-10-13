
namespace DictionaryDS
{
    public partial class Dictionary<TKey, TValue>
    {
        public void Remove(TKey Key)
        {
            int index = 0;

            bool check = true;

            for(int i = 0; i<_count; i++)
            {
                if(Key.Equals(Array[i].Key))
                {
                    index = i;
                    check = true;
                }
                else
                {
                    check = false;
                }
            }

            if(!check)
            {
                System.Console.WriteLine("Key is not present");
            }
            else
            {
                for(int i= 0; i<_count+1; i++ )
                {
                    if(i>=index)
                    {
                        Array[i].Key = Array[i+1].Key;
                        Array[i].Value = Array[i+1].Value;
                    }
                }
            }

            _count--;
        }
    
        public void Clear()
        {
            for(int i =0; i<_count; i++)
            {
                Array[i].Key = default(TKey);
                Array[i].Value = default(TValue);
            }

            _count = 0;
        }
    }
}