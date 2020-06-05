using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWork
{
    class ShellSorter<T> : ISorter<T>
        where T : IComparable
    {
        public void Sort(ref T[] arr)
        {
            int n = arr.Length;

            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                
                for (int i = gap; i < n; i += 1)
                {
                    
                    T temp = arr[i];

                    int j;
                    for (j = i; j >= gap && arr[j - gap].CompareTo(temp) > 0; j -= gap)
                        arr[j] = arr[j - gap];

                    arr[j] = temp;
                }
            }
        }
    }
}

