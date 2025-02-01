using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_Advanced.Assignmnet001
{
    //implement Early termenation
    public class BubbleSort
    {
        public static void swap(ref int x,ref int y)
        {
            int temp=x;
            x=y;
            y=temp;
        }

        public static void OptimizedBubblesort(int[] arr)
        {
            bool swapped;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        swap(ref arr[j], ref arr[j + 1]);
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
        }
            
    }
}
