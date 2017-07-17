using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class myAlgorithms
    {
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
    }
}
