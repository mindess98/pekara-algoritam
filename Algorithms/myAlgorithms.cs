using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    static class myAlgorithms
    {
       
        public delegate void SortingDelegate(List<int> array);
        public delegate int SearchingDelegate(List<int> array, int key);
        public delegate bool BooleanDelegate(int n);

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

        public static bool isPrime(int n)
        {
            List<bool> isPrime = new List<bool>();
            isPrime.Add(false);
            isPrime.Add(false);
            for (int i = 2; i <= n; i++)
            {
                isPrime.Add(true);
            }
            for (int i = 2; i <= n; i++)
            {
                for (int j = i * 2; j <= n; j += i)
                {
                    isPrime[j] = false;
                }
            }
            return isPrime[n];
        }
        public static bool isHappy(int n)
        {
            int sum = 0;
            List<int> numbersList = new List<int>();

            while (true)
            {
                while (n > 0)
                {
                    sum += (n % 10) * (n % 10);
                    n /= 10;
                }
                if (sum == 1)
                    return true;
                else
                {
                    foreach (int number in numbersList)
                        if (number == sum)
                            return false;
                    numbersList.Add(sum);
                    n = sum;
                    sum = 0;
                }
            }
        }
        public static bool isLucky(int n)
        {
            if (n <= 0) return false;
            List<int> isLucky = new List<int>();
            for (int i = 0; i <= n; i++)
                isLucky.Add(i);
            int k = isLucky.Count;
            for (int i = 1; i <= k; i++)
            {
                for (int j = i + 1; j < k; j += i)
                {
                    isLucky.RemoveRange(j, 1);
                    k--;
                }
            }
            if (isLucky[isLucky.Count - 1] == n)
                return true;
            return false;
        }

        public static void SortByID(int id, List<int> array)
        {
            myAlgorithms.delList[id](array);
        }
        public static bool AlgByID(int id, int n)
        {
            return booList[id](n);
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

        private static List<SortingDelegate> delList = new List<SortingDelegate> { BubbleSort, InsertionSort, QuickSort, MergeSort };
        private static List<SearchingDelegate> serList = new List<SearchingDelegate> { linearSearch, binarySearch };
        private static List<BooleanDelegate> booList = new List<BooleanDelegate> { isPrime, isHappy, isLucky };
    }
}
