using System;

//直接插入排序
//两层遍历，时间复杂度O(n^2);原地操作，空间复杂度O(1)
//稳定排序
//实现：将未排序部分第一位与已排序部分比较，将已排序部分中大于该位的元素后移，再插入。
class InsertionSort
{
    static void InsertionSortAlgorithm(int[] arr)
    {
        for(int i=1;i<arr.Length;i++){
            int key = arr[i];
            int j = i-1;//起始为前一位
            while(j>=0&&arr[j]>key){
                arr[j+1] = arr[j];
                j = j - 1;//后移次数刚好等于内部--次数，j始终为前一位
            }//将大于key的元素后移
            arr[j+1] = key;//j+1当前位置
        }
    }
}

//二分插入排序
//使用二分查找优化已排序部分的查找过程
//时间复杂度O(n^2)，但平均情况下比直接插入排序快
//原地操作，空间复杂度O(1)
//稳定排序
class BinaryInsertionSort
{
    static void BinaryInsertionSortAlgorithm(int[] arr)
    {
        for(int i=1;i<arr.Length;i++){
            int key = arr[i];
            int left = 0;
            int right = i-1;
            
            //使用二分查找找到插入位置
            while(left <= right){
                int mid = left + (right - left)/2;
                if(key < arr[mid]){
                    right = mid - 1;//if条件确保right为插入位置的前一位，结束条件确保left为right后一位，故left为插入位置
                }else{
                    left = mid + 1;
                }
            }
            
            //将大于key的元素后移
            for(int j=i-1;j>=left;j--){
                arr[j+1] = arr[j];
            }
            
            arr[left] = key;//插入到正确位置
        }
    }
}

//希尔排序
//分组插入排序，时间复杂度O(n^1.3)~O(n^2)，取决于增量序列
//原地操作，空间复杂度O(1)
//不稳定排序
//实现：先按增量分组进行插入排序，逐步缩小增量直至为1
class ShellSort
{
    static void ShellSortAlgorithm(int[] arr)
    {
        int gap = arr.Length / 2;//初始增量为数组长度的一半
        
        while(gap > 0){
            for(int i = gap;i<arr.Length;i++){
                int key = arr[i];
                int j = i - gap;
                while(j>=0&&key<arr[j]){
                    arr[j+gap] = arr[j];
                    j = j - gap;
                }
                arr[j+gap] = key;//插入到正确位置
            }
            gap = gap / 2;//缩小增量
        }
    }
}