using System;

//归并排序
//分治策略，时间复杂度O(n log n);需要额外空间，空间复杂度O(n)
//稳定排序
//实现：将数组递归分解为两个子数组，分别排序后合并为一个有序数组
class MergeSort
{
    static void MergeSortAlgorithm(int[] arr)
    {
        MergeSortRecursive(arr, 0, arr.Length - 1);
    }

    static void MergeSortRecursive(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;
            
            MergeSortRecursive(arr, left, mid);
            MergeSortRecursive(arr, mid + 1, right);
            
            Merge(arr, left, mid, right);
        }
    }

    static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;
        
        int[] leftArr = new int[n1];
        int[] rightArr = new int[n2];
        
        for (int i = 0; i < n1; i++)
        {
            leftArr[i] = arr[left + i];
        }
        for (int j = 0; j < n2; j++)
        {
            rightArr[j] = arr[mid + 1 + j];
        }
        
        int iLeft = 0, iRight = 0, k = left;
        
        while (iLeft < n1 && iRight < n2)
        {
            if (leftArr[iLeft] <= rightArr[iRight])
            {
                arr[k] = leftArr[iLeft];
                iLeft++;
            }
            else
            {
                arr[k] = rightArr[iRight];
                iRight++;
            }
            k++;
        }
        
        while (iLeft < n1)
        {
            arr[k] = leftArr[iLeft];
            iLeft++;
            k++;
        }
        
        while (iRight < n2)
        {
            arr[k] = rightArr[iRight];
            iRight++;
            k++;
        }
    }
}