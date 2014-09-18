using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
                        
            ArrayInit ai = new ArrayInit();
            MergeSort ms = new MergeSort();
            QuickSort qs = new QuickSort();
            PrintResult print = new PrintResult();
            MSort mats = new MSort();
           
            int[][] mat = new int[5][];

            int[] arr = new int[30];
            int[] mSortedArray = new int[arr.Length];
            int[] qSortedArray = new int[arr.Length];
           
            arr = ai.Init(arr);
                       
            System.Console.WriteLine("New Array:");

            print.Print(arr);
           


            mSortedArray = ms.Sort(arr);

            System.Console.WriteLine("Merge sorted array:");

            print.Print(mSortedArray);

            

            qSortedArray = arr;
            qs.QSort(qSortedArray, 0, qSortedArray.Length - 1);

            System.Console.WriteLine("Quick sorted array:");

            print.Print(qSortedArray);

            System.Console.WriteLine("New Matrix :");
            mat = ai.Init(mat);
            
            print.Print(mat);

            mats.SortBySumm(mat);

            print.Print(mat);
        

        }

        

    }
}
