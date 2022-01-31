using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErraiTechnicalTest
{
    internal class SortingAlgo
    {
        #region QuickSort
        public static async Task<(Double[] result, Double timer)> QuickSortAlgoAsync(Double[] input)
        {
            DateTime startTime = DateTime.Now;

            Double[] result = input;
            await Task.Run(() => QuickSort(result, 0, result.Length - 1));

            return (result, (DateTime.Now - startTime).TotalMilliseconds);
        }

        private static void QuickSort(Double[] arr, int low, int high)
        {
            int PivotIndex;

            if (low < high)
            {
                PivotIndex = Partition(arr, low, high);

                QuickSort(arr, low, PivotIndex - 1);
                QuickSort(arr, PivotIndex + 1, high);
            }
        }

        private static int Partition(Double[] arr, int low, int high)
        {
            Double temp;
            Double p = arr[high];
            int i = low - 1;

            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] <= p)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            temp = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp;
            return i + 1;
        }
        #endregion
        #region BubbleSort
        public static async Task<(Double[] result, Double timer)> BubbleSortAlgoAsync(Double[] input)
        {
            DateTime startTime = DateTime.Now;

            Double[] result = input;
            await Task.Run(() => BubbleSort(input));

            return (result, (DateTime.Now - startTime).TotalMilliseconds);
        }

        private static void BubbleSort(Double[] arr)
        {
            bool sorted = false;
            Double temp = 0;
            int length = arr.Length;

            while (!sorted)
            {
                if (length == 1) break;

                sorted = true;

                for (int i = 1; i < length; i++)
                {
                    if (arr[i] > arr[i - 1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = temp;

                        sorted = false;
                    }

                }
                
                length--;
            }
        }
        #endregion
    }

}
