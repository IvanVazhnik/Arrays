using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MSort
    {
        


        public int[][] SortBySumm(int[][] matrix)
        {
           int[] temp = new int[matrix.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = ElementSumm(matrix[i]);
            }
                                     
              
            foreach (int x in temp)
            {
                System.Console.Write(x + " ");
            }
            System.Console.ReadLine();                              
            


                return matrix;
        }




        public static int ElementSumm(int[] arr)
        {

            int summ = 0;
            foreach(int x in arr){
                summ += x;

            }

            return summ;
        }


    }
}
