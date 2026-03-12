using System;

class BaseDataClass
{
    public int i;
    //字符串
    public string str = "Hello World";
    public string str1 = new string('a', 5); //创建包含5个'a'的字符串

    void String(){
        //字符串拼接
        string s1 = "Hello";
        string s2 = "World";
        string s3 = s1 + " " + s2; //使用+号拼接
        string s4 = string.Concat(s1, " ", s2); //使用Concat方法拼接
        string s5 = string.Format("{0},{1}",1,2); //使用Format方法拼接
        string s6 = $"{s1} {s2}"; //使用字符串插值

        //字符串长度
        int length = s3.Length;

        //字符串截取
        string substr1 = s3.Substring(0, 5); //从索引0开始，截取5个字符
        string substr2 = s3.Substring(6); //从索引6开始，截取到末尾

        //字符串查找
        int index = s3.IndexOf("World"); //查找子串的索引
        int lastIndex = s3.LastIndexOf("o"); //查找最后一个匹配的索引
        bool contains = s3.Contains("Hello"); //判断是否包含子串

        //字符串替换
        string replaced = s3.Replace("World", "CSharp"); //替换子串

        //字符串分割
        string[] parts = s3.Split(' '); //按空格分割

        //字符串转换
        string upper = s3.ToUpper(); //转换为大写
        string lower = s3.ToLower(); //转换为小写
        int num = int.Parse("123"); //字符串转整数
        string numStr = 123.ToString(); //整数转字符串

        //字符串判断
        bool isEmpty = string.IsNullOrEmpty(""); //判断是否为空或null
        bool isWhiteSpace = string.IsNullOrWhiteSpace("   "); //判断是否为空白字符

        //字符串修剪
        string trimmed = "  Hello  ".Trim(); //修剪两端空白
        string trimmedStart = "  Hello  ".TrimStart(); //修剪开头空白
        string trimmedEnd = "  Hello  ".TrimEnd(); //修剪结尾空白

        //字符串比较
        bool equals = s1.Equals("Hello"); //比较字符串
        int compare = string.Compare(s1, "Hello"); //比较字符串大小

        //字符串格式化
        string formatted = string.Format("Name: {0}, Age: {1}", "John", 30);
        //string interpolated = $"Name: {'John'}, Age: {30}";
    }

    //数组
    public int[] Arr;

    public int[] Arr0 = { 1, 2, 3, 4, 5 };
    public int[] Arr1 = new int[10];
    //int[][]与int[,]的区别
    //int[][]交错数组：每行列数可以不同;不连续内存
    //int[,]二维数组：所有行列数必须相同;连续内存
    public int[][] Arr2 = new int[2][];//可以第一维指定，第二维不指定
    public int[,] Arr3 = new int[2, 3];//可以指定二维数组的大小,但是不能只指定第二维
    public int[][] Arr4 = {{1,2,3},{4,5,6}};

    //Array类
    void Array(){
        Array.Sort(Arr0);//排序
        Array.Reverse(Arr0);//反转
        Array.Copy(Arr0,Arr1,5);//复制
    }

    //列表
    public List<int> list = new List<int>();

    void List(){
        list.Add(1);//添加元素
        list.AddRange(new int[]{2,3,4});//添加范围

        int index = list.IndexOf(3);//查找元素的索引
        bool contains = list.Contains(2);//判断是否包含元素

        list.Remove(3);//移除元素
        list.RemoveAt(0);//移除指定索引的元素
        list.Clear();//清空列表

        list.Sort();//排序
        int[] arr = list.ToArray();//转换为数组
    }

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