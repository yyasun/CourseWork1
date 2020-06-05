using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseWork
{
    class SelectionSorter<T> : ISorter<T>
                where T : IComparable
    {
        public void Sort(ref T[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                int minInd = i;
                for (int j = i + 1; j < arr.Length;j++)
                {
                    if (arr[minInd].CompareTo(arr[j]) > 0)
                        minInd = j;
                }
                
                Swap(arr, minInd,i);
            }
        }
        private void Swap(T[] arr, int minIndex, int curI)
        {
            T tmp = arr[minIndex];
            arr[minIndex] = arr[curI];
            arr[curI] = tmp;
        }
    }
}
