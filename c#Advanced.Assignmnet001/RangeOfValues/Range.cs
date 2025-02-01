using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_Advanced.Assignmnet001.RangeOfValues
{
    public class Range<T> where T:IComparable<T>
    {
        public T maximum { get; }
        public T minimum { get; }

        public Range(T min , T max)
        {
            if (min.CompareTo(max) > 0)
                throw new ArgumentException("max value should be greater than min value ");
            maximum = max;
            minimum = min;
            
        }
        //check if value within range or not 
        public bool IsInRange(T value)
        {
            return value.CompareTo(minimum) >= 0 && value.CompareTo(maximum)<=0;


        }

        public T length()
        {
            dynamic min = minimum;
            dynamic max = maximum;
            return max-min;
        }

    }
}
