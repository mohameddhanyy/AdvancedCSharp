using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_
{
    internal class Range<T> where T : IComparable
    {
        public T Minimum { get; set; }
        public T Maximum { get; set; }

        public Range(T minimum, T maximum)
        {
            Minimum = minimum;
            Maximum = maximum;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Minimum)>=0 && value.CompareTo(Maximum) <=0;
        }

        public T Length() 
        {
            dynamic Min = Minimum;
            dynamic Max = Maximum;
            return Max - Min;
        }
    }
}
