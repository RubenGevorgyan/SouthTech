using System;
using System.Collections.Generic;
using System.Text;

namespace SouthTech
{
    class FactorySort
    {
        public ISort ChooseSort(string[] data,Priority choice)
        {
            switch (choice)
                {
                //2 = less than 1000, no memory; 4 = more than 1000, no memory; 3 = less then 1000, memory; 5 = more than 1000, memory;
                case Priority.Speed: return new QuickSort();
                case Priority.Memory: return new HeapSort();
                default: return new BubbleSort();
                }

        }
    }
}
