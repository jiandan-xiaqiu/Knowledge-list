using System;

//选择排序
//每次找到最小的放在前面
//时间复杂度O(n^2)
//原地操作，空间复杂度O(1)
//不稳定排序

class SelectionSort{
    static void SelectionSortAlgorithm(int[] arr){
        for(int i = 0;i<arr.Length;i++){
            int min = i;//记录位置
            for(int j = i+1;j<arr.Length;j++){
                if(arr[j]<arr[min]){
                    min = j;
                }
            }
            int temp = arr[i];//将最小与循环位交换
            arr[i] = arr[min];
            arr[min] = temp;
        }
    }
}


//堆排序
//利用堆这种数据结构进行排序
//堆是一棵完全二叉树，满足堆性质：每个节点的值都大于等于（大顶堆）或小于等于（小顶堆）其子节点的值
//时间复杂度O(nlogn)
//原地操作，空间复杂度O(1)
//不稳定排序

class HeapSort{
    static void HeapSortAlgorithm(int[] arr){
        //第一步：构建大顶堆
        //从最后一个非叶子节点开始，自下而上调整堆
        //最后一个非叶子节点索引为 arr.Length/2-1
        for(int i = arr.Length/2-1;i>=0;i--){
            Heapify(arr,i,arr.Length);
        }
        
        //第二步：逐个提取堆顶元素（最大值）放到数组末尾
        for(int i = arr.Length-1;i>0;i--){
            //将堆顶元素（最大值）与当前末尾元素交换
            int temp = arr[i];
            arr[i] = arr[0];
            arr[0] = temp;
            
            //交换后，堆的性质被破坏，需要重新调整堆
            //注意：每次调整的范围缩小，已排好序的末尾元素不再参与调整
            Heapify(arr,0,i);
        }
    }
    
    //堆化操作：调整以节点i为根的子树，使其满足大顶堆性质
    //length表示当前堆的有效长度（已排序的元素不参与调整）
    static void Heapify(int[] arr, int i, int length){
        int left = 2*i+1;   //左子节点索引
        int right = 2*i+2;  //右子节点索引
        int largest = i;    //记录当前节点、左子节点、右子节点中最大值的索引
        
        //如果左子节点存在且大于当前最大值，更新最大值索引
        if(left<length&&arr[left]>arr[largest]){
            largest = left;
        }
        
        //如果右子节点存在且大于当前最大值，更新最大值索引
        if(right<length&&arr[right]>arr[largest]){
            largest = right;
        }
        
        //如果最大值不是当前节点，说明需要交换
        if(largest!=i){
            //交换当前节点与最大子节点
            int temp = arr[i];
            arr[i] = arr[largest];
            arr[largest] = temp;
            
            //交换后，子树可能不再满足堆性质，需要递归调整
            Heapify(arr,largest,length);
        }
    }
}
