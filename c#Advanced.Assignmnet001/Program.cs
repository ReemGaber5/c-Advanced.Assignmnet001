using c_Advanced.Assignmnet001.RangeOfValues;

namespace c_Advanced.Assignmnet001
{
    internal class Program
    {
        //we can optimize bubble sort algorithm using several metods like :
        //1-early detaction(usng flag)
        //2-comb sort 
        //3-Cocktail sort
        //if it's large datasets we can use quicksort
        static void Main(string[] args)
        {
            ////implement Early termenation

            //int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            //BubbleSort.OptimizedBubblesort(arr);
            //foreach (int i in arr) 
            //{
            //    Console.WriteLine(i);
            //}


            #region Question2

            var range=new Range<int>(5,10);
            Console.WriteLine("Is it in range? " + range.IsInRange(7)); 
            Console.WriteLine("The length is " + range.length());

            #endregion


        }
    }
}
 