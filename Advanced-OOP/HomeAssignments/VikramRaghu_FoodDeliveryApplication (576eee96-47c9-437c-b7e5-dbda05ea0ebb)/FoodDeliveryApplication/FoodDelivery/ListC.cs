

namespace FoodDelivery
{
    public partial class List<Type>
    {
           public void Remove(Type data)
           {
                int counter = 0;
                Type[] temp = new Type[_capacity];
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