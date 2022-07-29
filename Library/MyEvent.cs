namespace Library
{
    public class MyEvent
    {
        /// <summary>
        /// Action类型事件
        /// </summary>
        public static event Action actionEvent = () => { Console.WriteLine("事件默认初始化"); };

        /// <summary>
        /// 初始化事件值
        /// </summary>
        public static void InitEvent()
        {
            actionEvent = () => { Console.WriteLine("事件初始化"); };
        }

        /// <summary>
        /// 事件同步调用
        /// </summary>
        public static void ExecuteEvent()
        {
            actionEvent.Invoke();
            actionEvent();//语法糖
        }

        /// <summary>
        /// 事件异步调用
        /// </summary>
        public static void ExecuteAsyncEvent()
        {
            //AsyncCallback参数传入回调方法(委托)
            //object参数传入回调State参数，回调方法中使用IAsyncResult参数类型的AsyncState属性获取
            //后台线程
            IAsyncResult asyncResult = actionEvent.BeginInvoke(
                (p) =>
                {
                    Console.WriteLine(p.AsyncState);
                },
                "回调State参数");

            while (!asyncResult.IsCompleted) { };//IsCompleted判断操作是否完成
            asyncResult.AsyncWaitHandle.WaitOne();//阻塞等待操作完成
            actionEvent.EndInvoke(asyncResult);//阻塞等待操作完成，获取返回类型
        }
    }
}
