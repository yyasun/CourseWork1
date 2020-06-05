using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWork
{
    class PyramidSorter<T> : ISorter<T>
                where T : IComparable
    {            
        void heapify(T[] arr, int n, int i)
        {
            int largest = i; 
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            
            if (l < n && arr[l].CompareTo(arr[largest])>0)
                largest = l;

            
            if (r < n && arr[r].CompareTo(arr[largest]) > 0)
                largest = r;

            if (largest != i)
            {
                T swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
    
                heapify(arr, n, largest);
            }
        }

        public void Sort(ref T[] arr)
        {
            int n = arr.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);

            for (int i = n - 1; i > 0; i--)
            {
                T temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                heapify(arr, i, 0);
            }
        }
    }
}
