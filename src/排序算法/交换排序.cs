using System;

//冒泡排序
//两层遍历，时间复杂度O(n^2);原地操作，空间复杂度O(1)
//稳定排序
//实现：将未排序部分与已排序部分比较，将大于该位的元素后移，再插入。
class BubbleSort
{
    static void BubbleSortAlgorithm(int[] arr)
    {
        for(int i=0;i<arr.Length;i++){
            for(int j=0;j<arr.Length-i-1;j++){
                if(arr[j]>arr[j+1]){
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
        }
    }
}


//快速排序
/*
寻找一个枢轴，以两个指针从数组两端向中间移动，
将其中一指针所指与枢轴对比,大于枢轴赋值到右指针，将小于枢轴赋值到左指针。（以从小到大为例）
若发生赋值，则切换指针，继续比较。
当两个指针相遇时，即枢轴位置。
然后重复以上过程，对枢轴左右子数组排序。
*/
//时间复杂度O(nlogn)，最坏情况下O(n^2)
//原地操作，空间复杂度O(1)
//不稳定排序

class QuickSort
{
    void QuickSortAlgorithm(int[] arr, int left, int right)
    {
        if(left >= right){
            return;
        }
        int pivot = partition(arr,left,right);//找到枢轴位置，并在过程中排序
        QuickSortAlgorithm(arr,left,pivot-1);//对枢轴左右递归
        QuickSortAlgorithm(arr,pivot+1,right);
    }
    int partition(int[] arr, int left, int right)
    {
        int key = arr[left];
        while(left<right){
            while(left<right&&arr[right]>=key){
                right--;
            }//从右指针找到小于枢轴的元素
            arr[left] = arr[right];
            while(left<right&&arr[left]<=key){
                left++;
            }//从左指针找到大于枢轴的元素
            arr[right] = arr[left];
        }
        arr[left] = key;//插入枢轴
        return left;    
    }
}