
namespace ArrayListDS
{
    public partial class ArrayList
    {
        public void Insert(int index, dynamic data)
        {   
           if(_count == _capacity)
            {  
                _capacity = _capacity + 3;
            }

            dynamic[] temp = new dynamic[_capacity];

            int count = 0;
            for(int i=0; i<_count; i++)
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