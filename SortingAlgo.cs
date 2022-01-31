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

            Double[] result = (Double[])input.Clone();
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

            Double[] result = (Double[])input.Clone();

            await Task.Run(() => BubbleSort(result));

            return (result, (DateTime.Now - startTime).TotalMilliseconds);
        }

        private static void BubbleSort(Double[] arr)
        {
            Double temp;

            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }
    #endregion

    #region MergeSort
    public static async Task<(Double[] result, Double timer)> MergeSortAlgoAsync(Double[] input)
    {
        DateTime startTime = DateTime.Now;

        Double[] result = (Double[])input.Clone();
        await Task.Run(() => MergeSort(result, 0, result.Length - 1));

        return (result, (DateTime.Now - startTime).TotalMilliseconds);
    }

    private static void MergeSort(Double[] arr, int low, int high)
    {
        int mid;
        if (high > low)
        {
            mid = (high + low) / 2;
            MergeSort(arr, low, mid);
            MergeSort(arr, (mid + 1), high);
            Merge(arr, low, (mid + 1), high);
        }
    }

    private static void Merge(Double[] numbers, int left, int mid, int right)
    {
        Double[] temp = new Double[numbers.Length];
        int i, left_end, num_elements, tmp_pos;
        left_end = (mid - 1);
        tmp_pos = left;
        num_elements = (right - left + 1);
        while ((left <= left_end) && (mid <= right))
        {
            if (numbers[left] <= numbers[mid])
                temp[tmp_pos++] = numbers[left++];
            else
                temp[tmp_pos++] = numbers[mid++];
        }
        while (left <= left_end)
            temp[tmp_pos++] = numbers[left++];
        while (mid <= right)
            temp[tmp_pos++] = numbers[mid++];
        for (i = 0; i < num_elements; i++)
        {
            numbers[right] = temp[right];
            right--;
        }
    }
    #endregion

    #region GCF
    const int COMPARE_NUM = 20;
    public static async Task<(Double[] result, Double timer)> GCFSortAlgoAsync(Double[] input)
    {
        DateTime startTime = DateTime.Now;

        Double[] inputClone = (Double[])input.Clone();
        Double[][] arr = inputClone.Select(val => new[] { val, (Double)GCF(COMPARE_NUM, (int)val) }).ToArray();

        await Task.Run(() => GCFSort(arr, 0, arr.Length - 1));

        Double[] result = arr.Select(val => val[0]).ToArray();
        return (result, (DateTime.Now - startTime).TotalMilliseconds);
    }

    private static void GCFSort(Double[][] arr, int low, int high)
    {
        // reimplement quick sort
        int PivotIndex;

        if (low < high)
        {
            PivotIndex = PartitionGCF(arr, low, high);

            GCFSort(arr, low, PivotIndex - 1);
            GCFSort(arr, PivotIndex + 1, high);
        }
    }
    private static int PartitionGCF(Double[][] arr, int low, int high)
    {
        Double[] temp;
        Double p = arr[high][1];
        int i = low - 1;

        for (int j = low; j <= high - 1; j++)
        {
            if (arr[j][1] <= p)
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

    private static int GCF(int numA, int numB)
    {
        while (numA != numB)
        {
            if (numA > numB)
                numA -= numB;
            else
                numB -= numA;
        }

        return numA;
    }
    #endregion
}

}
