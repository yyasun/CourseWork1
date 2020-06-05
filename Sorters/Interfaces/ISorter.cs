using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWork
{
    interface ISorter<T> where T: IComparable
    {
        void Sort(ref T[] arr);
    }
}
