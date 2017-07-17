using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class myAlgorithms
    {
       
        public delegate void SortingDelegate(List<int> array);
        public static void BubbleSort(List<int> array)
        {
            for(int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array.Count - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
        public static void InsertionSort(List<int> array)
        {
            for(int i = 0; i < array.Count; i++)
            {
                int max = array[i];
                int maxIndex = i;
                for (int j = i; j < array.Count; j++)
                {
                    if(array[j] > max)
                    {
                        max = array[j];
                        maxIndex = j;
                    }
                }
                int temp = array[i];
                array[i] = array[maxIndex];
                array[maxIndex] = temp;
            }
        }
        public static void QuickSort(List<int> array)
        {
            qSort(array, 0, array.Count-1);
        }
        private static void qSort(List<int> array, int left, int right)
        {
           if(left < right)
            {
                int pivot = array[left];
                int i = left;
                int j = right;
                while (true)
                {
                    while (array[i] > pivot)
                        i++;
                    while (array[j] < pivot)
                        j--;
                    if (i >= j)
                        break;
                    if (array[i] == array[j])
                    {
                        i++; j--;
                    }
                    else
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }

                qSort(array, left, j);
                qSort(array, j + 1, right);
            } 
        }
        public static void MergeSort(List<int> array)
        {
            mSort(array, 0, array.Count - 1);
        }
        private static void mSort(List<int> array, int left, int right)
        {
            if(left < right)
            {
                int mid = (right + left) / 2;
                mSort(array, left, mid);
                mSort(array, mid + 1, right);

                merge(array, left, right, mid);
            }
        }
        private static void merge(List<int> array, int left, int right, int mid)
        {
            int k = 0;
            int size = right - left + 1;
            int[] m = new int[size];

            int i = left;
            int j = mid + 1;

            while (i <= mid && j <= right)
            {
                if (array[i] < array[j])
                    m[k++] = array[j++];
                else
                    m[k++] = array[i++];                
            }
            for (k = 0, i = left; i <= right; k++, i++)
                array[i] = m[k];
        }
        public static void SortByID(int id, List<int> array)
        {
            myAlgorithms.delList[id](array);
        }

        public static List<SortingDelegate> delList = new List<SortingDelegate> { BubbleSort, InsertionSort, QuickSort, MergeSort };

    }
}
