using System;

class BaseDataClass
{
    public int i;
    //数组
    public int[] Arr;

    public int[] Arr0 = { 1, 2, 3, 4, 5 };
    public int[] Arr1 = new int[10];
    //int[][]与int[,]的区别
    //int[][]交错数组：每行列数可以不同;不连续内存
    //int[,]二维数组：所有行列数必须相同
    public int[][] Arr2 = new int[2][];//可以第一维指定，第二维不指定
    public int[,] Arr3 = new int[2, 3];//可以指定二维数组的大小,但是不能只指定第二维
    public int[][] Arr4 = {{1,2,3},{4,5,6}};

    //栈
    public Stack<int> stack = new Stack<int>();

    void Stack(){
        stack.Push(1);//压入元素

        int pop = stack.Pop();//弹出元素

        if(stack.Peek() == 1)//查看栈顶元素
        {
            Console.WriteLine("栈顶元素为1");
        }

        if(stack.Count == 0)//判断栈是否为空
        {
            Console.WriteLine("栈为空");
        }

    }

    //队列
    public Queue<int> queue = new Queue<int>();

    void Queue(){
        queue.Enqueue(1);//入队
        int dequeue = queue.Dequeue();//出队
        if(queue.Peek() == 1)//查看队头元素
        {
            Console.WriteLine("队头元素为1");
        }
        if(queue.Count == 0)//判断队列是否为空
        {
            Console.WriteLine("队列为空");
        }
    }
    
    //字典
    public Dictionary<int,string> dict = new Dictionary<int,string>();
    void Dict(){

        dict.Add(1,"one");//添加键值对

        string d1 = dict[1];//通过键获取值

        if(dict.ContainsKey(1))//判断是否包含指定的键
        {
            Console.WriteLine("包含键1");
        }

        if(dict.ContainsValue("one"))//判断是否包含指定的值
        {
            Console.WriteLine("包含值one");
        }

        dict.Remove(1);//移除指定的键值对
        dict.Remove("one");//移除指定的值

        string value;
        dict.Remove(1,out value);//移除指定的键值对并返回值

        foreach(KeyValuePair<int,string> kvp in dict)//遍历字典
        {
            Console.WriteLine("键：{0}，值：{1}",kvp.Key,kvp.Value);
        }

        int[] keys = dict.Keys.ToArray();//获取字典的所有键

        int[] keys1 = dict.Keys.ToArray();//获取字典的所有键,Keys为KeyCollection类型，需通过ToArray()转换为数组

        string[] values = dict.Values.ToArray();//获取字典的所有值，Values为ValueCollection类型，需通过ToArray()转换为数组

        if(dict.Count == 0)//判断字典是否为空
        {
            Console.WriteLine("字典为空");
        }

        dict.Clear();//清空字典
    }
}