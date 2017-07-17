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
        public static void SortByID(int id, List<int> array)
        {
            myAlgorithms.delList[id](array);
        }
        public static int binarySearch(List<int> array, int key)
        {

            int left = 0;
            int right = array.Count - 1;
            int mid;

            while (left < right)
            {
                mid = (left + right) / 2;
                if (array[mid] == key)
                {
                    return mid;
                }
                if(array[mid] > key)
                {
                    left = mid + 1; 
                }
                if(array[mid] < key)
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
        public static int linearSearch(List<int> array, int key)
        {
            for(int i = 0; i < array.Count; i++)
            {
                if (array[i] == key)
                    return i;
            }
            return -1;
        }


        public static List<SortingDelegate> delList = new List<SortingDelegate> { BubbleSort, InsertionSort };

    }
}
