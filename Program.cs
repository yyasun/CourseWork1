using System;
using System.Buffers;

namespace CourseWork
{
    class Program
    {
        static void Main(string[] args)
        {
            ISorter<int> sorter;
            Console.WriteLine("How would you like to SORT?");
            Console.WriteLine("1 - selection sort ");
            Console.WriteLine("2 - shell sort ");
            Console.WriteLine("3 - heap sort ");
            int sorterType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input arr size>1000:");
            int length= Convert.ToInt32(Console.ReadLine());

            var arr = GenerateArr(length);
            ChooseSorter<int>(sorterType, out sorter);
            sorter.Sort(ref arr);
            foreach(var i in arr)
                Console.Write(i.ToString() + " ");
        }
        static int[] GenerateArr(int size)
        {
            int[] arr = new int[size];
            var r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-100,100);
            }
            return arr;
        }
        static void ChooseSorter<T>(int sorterType, out ISorter<T> sorter) where T: IComparable
        {
            if (sorterType == 1)
            {
                sorter = new SelectionSorter<T>();
            }
            else if (sorterType == 2)
            {
                sorter = new ShellSorter<T>();
            }
            else 
            {
                sorter = new PyramidSorter<T>();
            }
        }
    }
}
