using System.Collections;

namespace FoodDelivery
{
    public partial class List<Type> : IEnumerable, IEnumerator
    {
        private int position;

        public IEnumerator GetEnumerator()
        {
            position = -1;
            return (IEnumerator)this;
        }

        public bool MoveNext()
        {
            if(position < _count - 1)
            {
                ++position;
                return true;
            }
            // Reset Position value if no element in List
            Reset();    
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current
        {
            get { return Array[position]; } 
        } 
    }
}