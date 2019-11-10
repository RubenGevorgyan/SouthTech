using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using SouthTech;

namespace SouthTech
{
    interface ISort
    {
        string[] _data { get; set; }
        void Sort();
    }

    class BubbleSort :ISort
    {
        public string[] _data { get; set; }
        public void Sort()
        {
            string temp;
            string[] data = _data;
            for (int j = 0; j <= data.Length - 2; j++)
            {
                for (int i = 0; i <= data.Length - 2; i++)
                {
                    if (TComparer.Compare(data[i], data[i + 1]) == 1)
                    {
                        temp = data[i + 1];
                        data[i + 1] = data[i];
                        data[i] = temp;
                    }
                }
            }
            _data = data;

        }
    }

    class HeapSort:ISort 
    {

        public string[] _data { get; set; }
        public void Sort()
        {
            string[] data = _data;
            int n = data.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(data, n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                string temp = data[0];
                data[0] = data[i];
                data[i] = temp;
                heapify(data, i, 0);
            }
        }
        private void heapify(string[] data, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && TComparer.Compare(data[left], data[largest]) == 1)
                largest = left;
            if (right < n && TComparer.Compare(data[right], data[largest]) == 1)
                largest = right;
            if (largest != i)
            {
                string swap = data[i];
                data[i] = data[largest];
                data[largest] = swap;
                heapify(data, n, largest);
            }
        }
    }

    class QuickSort:ISort
    {
        public string[] _data { get; set; }
        public void Sort()
        {
            string[] data = _data;
            Quick_Sort(data, 0, data.Length - 1);
        }
        private static void Quick_Sort(string[] data, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(data, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(data, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(data, pivot + 1, right);
                }
            }
            
        }

        private static int Partition(string [] data, int left, int right)
        {
           
            string pivot = data[left];
            while (true)
            {
                while (TComparer.Compare( data[left] , pivot)==-1)
                {
                    left++;
                }

                while (TComparer.Compare( data[right] , pivot)==1)
                {
                    right--;
                }

                if (left < right)
                {
                    if (TComparer.Compare(data[left],data[right])==0) return right;

                    string temp = data[left];
                    data[left] = data[right];
                    data[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }
    }
}
