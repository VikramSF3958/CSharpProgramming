
namespace FoodDelivery
{
    public partial class List<Type>
    {
        public void RemoveAt(int index, Type data)
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
    }
}