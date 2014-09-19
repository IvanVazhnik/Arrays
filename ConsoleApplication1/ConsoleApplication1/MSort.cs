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
            int size = 0;
            int[][] sortedMatrix = new int[matrix.Length][];
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    size++;
                    sortedMatrix[i] = new int[size+1];
                }
                size = 0;
            }


           for (int i = 0; i < matrix.Length; i++)
            {
               for (int j = 0; j < matrix[i].Length; j++)
                {
                   
                    sortedMatrix[i][j] = matrix[i][j];
                }
               
            }
                     
            
              int last;
                   for (int i = 0; i < sortedMatrix.Length; i++)
                     {
                         last = sortedMatrix[i].Length-1;
                         sortedMatrix[i][last] = ElementSumm(matrix[i]);
                      }




                 /*  for (int i = 0; i < matrix.Length; i++)
                   {
                       for (int j = 0; j < matrix.Length-1; j++)
                       {
                            last = sortedMatrix[i].Length-1;
                            if (sortedMatrix[i][last] > sortedMatrix[i + 1][last])
                            {

                            }

                         
                       }

                   }
            
            */
            
            
            
            
            
            
         
                    



                return sortedMatrix;
        }

       




        public static int ElementSumm(int[] arr)
        {

            int summ = 0;
            foreach(int x in arr){
                summ += x;

            }

            return summ;
        }

        public static int MinElement(int[] arr)
        {
            int min = 100;
            int pos = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                    pos = i;

                }
            }
            return pos;


        }


    }
}
