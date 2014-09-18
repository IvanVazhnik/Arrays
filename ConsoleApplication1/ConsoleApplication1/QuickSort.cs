using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class QuickSort
    {



        public void QSort(int[] mass,int start,int last)
        {
           
           int p = mass[(last - start)/2 + start]; //p - средний элмент в текущем подмассиве
           int temp;
           int i = start;
           int j = last; //i - индекс первого, j- индекс последнего
          
            while(i <= j) //пока не все элменты раскиданы относительно среднего шагаем по циклу
           {
             while(mass[i] < p && i <= last)  ++i; //пропускаем слева, те что меньше среднего
             while(mass[j] > p && j >= start) --j; //пропускаем слева, те что больше среднего
             if(i <= j)                //если есть не раскиданные элементы - меняем их местами
              {
                 temp = mass[i];   
                 mass[i] = mass[j];  //больший в левую половину подмассива
                 mass[j] = temp;   //меньший в правую
                 ++i; --j;        //переходим к следующим элментам
               }
            }
            if(j > start) QSort(mass, start, j); //вызываем сортировку рекурсивно для левого подмассива, если это требуется
            if(i < last)  QSort(mass, i, last);//вызываем себя рекурсивно для правого подмассива, если это требуется
          }
        }



    }

