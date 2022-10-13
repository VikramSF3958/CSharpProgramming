
namespace ArrayListDS
{
    public partial class ArrayList
    {
        public void RemoveAt(int index, dynamic data)
        {
           for(int i=0; i<_count; i++)
           {
                if(i < index)
                {
                    Array[i] = Array[i];
                }
                else if( index <= i)
                {
                    Array[i] = Array[i+1];
                }
           }
           _count--;
        }
    
         public void Remove(dynamic data)
           {
                int counter = 0;
                dynamic[] temp = new dynamic[_capacity];
                for(int i=0; i<_count; i++)
                {
                    if(data.Equals(Array[i]))
                    {
                        continue;
                    }
                    else
                    {
                        temp[counter] = Array[i];
                        counter++;
                    }

                }
                _count--;
                Array = temp;
           }
    }
}