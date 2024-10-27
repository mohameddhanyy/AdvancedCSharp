using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_
{
    class Helper<T> where T : IComparable<T>
    {
        public static T[] BubbleSort(T[] arr)
        {
            if (arr is null) return null;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) == 1)
                    {
                        T temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }

        // Optimized Bubble Sort 

    }
}
