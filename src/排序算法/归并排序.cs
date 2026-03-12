using System;

//归并排序
//分治策略，时间复杂度O(n log n);需要额外空间，空间复杂度O(n)
//稳定排序
//实现：将数组递归分解为两个子数组，分别排序后合并为一个有序数组
class MergeSort
{
    //归并排序主方法
    static void MergeSortAlgorithm(int[] arr)
    {
        //调用递归方法，从数组的第一个元素到最后一个元素
        MergeSortRecursive(arr, 0, arr.Length - 1);
    }

    //递归实现归并排序
    static void MergeSortRecursive(int[] arr, int left, int right)
    {
        //基本情况：当左索引小于右索引时继续递归
        if (left < right)
        {
            //计算中间索引，避免整数溢出
            int mid = left + (right - left) / 2;
            
            //递归排序左半部分
            MergeSortRecursive(arr, left, mid);
            //递归排序右半部分
            MergeSortRecursive(arr, mid + 1, right);
            
            //合并两个已排序的子数组
            Merge(arr, left, mid, right);
        }
    }

    //合并两个已排序的子数组
    //参数说明：arr-原数组，left-左子数组起始索引，mid-中间索引，right-右子数组结束索引
    static void Merge(int[] arr, int left, int mid, int right)
    {
        //计算左子数组和右子数组的长度
        int n1 = mid - left + 1;
        int n2 = right - mid;
        
        //创建临时数组来存储左右子数组
        int[] leftArr = new int[n1];
        int[] rightArr = new int[n2];
        
        //将原数组中的元素复制到临时数组
        for (int i = 0; i < n1; i++)
        {
            leftArr[i] = arr[left + i];
        }
        for (int j = 0; j < n2; j++)
        {
            rightArr[j] = arr[mid + 1 + j];
        }
        
        //初始化三个指针：左子数组指针、右子数组指针、原数组指针
        int iLeft = 0, iRight = 0, k = left;
        
        //比较左右子数组的元素，将较小的元素放入原数组
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
        
        //将左子数组中剩余的元素复制到原数组
        while (iLeft < n1)
        {
            arr[k] = leftArr[iLeft];
            iLeft++;
            k++;
        }
        
        //将右子数组中剩余的元素复制到原数组
        while (iRight < n2)
        {
            arr[k] = rightArr[iRight];
            iRight++;
            k++;
        }
    }
}