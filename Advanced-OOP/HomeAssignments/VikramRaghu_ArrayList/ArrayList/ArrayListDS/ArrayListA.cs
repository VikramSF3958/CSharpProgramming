

namespace ArrayListDS
{
    public partial class ArrayList
    {
        public void add(dynamic data)
        {
        if(_count == _capacity)
        {
            //Call GrowSize()
            GrowSize();

        }
        Array[_count] = data;
        _count++;
        }

        public void GrowSize()
        {
        int tempSize = _capacity;
        _capacity = _capacity * 2;

        dynamic[] temp = new dynamic[_capacity];

        for(int i=0; i<tempSize; i++)
        {
            temp[i] = Array[i];
        }

        Array = temp;
        }

        public int IndexOf(dynamic data)
        {   
            int index = -1;
            for(int i=0; i<_count; i++)
            {
                if(data.Equals(Array[i]))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
    }
}