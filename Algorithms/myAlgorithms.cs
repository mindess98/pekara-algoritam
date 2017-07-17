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
        public static List<bool> SieveOfEratosthenes(int n)
        {
            List<bool> isPrime = new List<bool>(n + 1);
            isPrime[0] = false;
            isPrime[1] = false;
            for (int i = 2; i <= n; i++)
            {
                isPrime[i] = true;
            }
            for(int i = 2; i <= n; i++)
            {
                for(int j = i * 2; j <= Math.Sqrt(n); j += i)
                {
                    isPrime[j] = false;
                }
            }
            return isPrime;
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
            List<int> isLucky = new List<int>(n + 1);
            isLucky[0] = -1;
            for (int i = 1; i < isLucky.Count; i++)
                isLucky[i] = i;
            for(int i = 1; i <= n; i++)
            {
                for(int j = i + 1; j < isLucky.Count; j += i)
                {
                    isLucky.RemoveRange(j, 1);
                }
            }
            foreach (int luckyNumber in isLucky)
                if (luckyNumber == n) return true;
            return false;
        }
        public static List<SortingDelegate> delList = new List<SortingDelegate> { BubbleSort, InsertionSort };

    }
}
