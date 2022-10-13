
namespace FoodDelivery
{
    public partial class List<Type>
    {
        public void Insert(int index, Type data)
        {   
           // int tempSize = _capacity;
            if(_count == _capacity)
            {  
                _capacity = _capacity + 1;
            }

            Type[] temp = new Type[_capacity];

            int count = 0;
            for(int i=0; i<_count+1; i++)
            {
                if(count==index)
                {
                    temp[count] = data;
                    count++;
                    i--;
                    continue;
                }
                temp[count] = Array[i];
                count++;
                
            }
            _count++;
            Array = temp;
        }
    }
}