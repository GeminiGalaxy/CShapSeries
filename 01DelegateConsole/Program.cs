using Library;

namespace DelegateConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 委托实例化
            //C#1.0(参数完全相同)
            MyPrint myPrint = new MyPrint();
            InputStrDelegate delInStr = new InputStrDelegate(myPrint.PrintStr);//非静态方法实例化
            delInStr = new InputStrDelegate(MyPrint.StaticPrintStr);//静态方法实例化

            //C# 2.0
            //匿名方法实例化
            delInStr = delegate (string strPara)
            {
                return;
            };
            delInStr = MyPrint.StaticPrintStr;//方法组转换实例化

            //省略参数列表的匿名方法(可以转换为具有任何参数列表的委托类型)
            delInStr = delegate
            {
                Console.WriteLine("委托实例化：省略参数列表的匿名方法(string)");
            };
            InputObjDelegate delInObj = delegate
            {
                Console.WriteLine("委托实例化：省略参数列表的匿名方法(object)");
            };

            //C#3.0
            //lambda表达式实例化
            delInStr = (p) =>
            {
                Console.WriteLine("委托实例化：lambda表达式");
            };
            #endregion

            #region 委托调用
            InputStrDelegate delInStrInvoke = (p) =>
            {
                Console.WriteLine("委托调用");
            };

            #region 同步调用
            delInStrInvoke.Invoke("参数");
            delInStrInvoke("参数");//语法糖
            #endregion

            #region 异步调用
            //AsyncCallback参数传入回调方法(委托)
            //object参数传入回调State参数，回调方法中使用IAsyncResult参数类型的AsyncState属性获取
            //IAsyncResult asyncResult = delInStrInvoke.BeginInvoke("参数",
            //    (p) =>
            //    {
            //        Console.WriteLine(p.AsyncState);
            //    },
            //    "回调State参数");//后台线程

            //while (!asyncResult.IsCompleted) { };//IsCompleted判断操作是否完成
            //asyncResult.AsyncWaitHandle.WaitOne();//阻塞等待操作完成
            //delInStrInvoke.EndInvoke(asyncResult);//阻塞等待操作完成，获取返回类型
            #endregion
            #endregion

            #region 委托多播
            //有返回类型的委托只会返回最后一个返回类型
            //委托列表遍历执行时如遇到异常，后面的委托不会继续执行
            InputStrDelegate delInStr1 = (p) =>
            {
                Console.WriteLine("委托多播：1" + " 参数：" + p);
            };
            InputStrDelegate delInStr2 = (p) =>
            {
                Console.WriteLine("委托多播：2" + " 参数：" + p);
            };
            InputStrDelegate delInStr3 = (p) =>
            {
                Console.WriteLine("委托多播：3" + " 参数：" + p);
            };

            InputStrDelegate? delInStrMC = Delegate.Combine(delInStr1, delInStr2) as InputStrDelegate;
            delInStrMC = Delegate.Combine(delInStrMC, delInStr3) as InputStrDelegate;
            delInStrMC = Delegate.Remove(delInStrMC, delInStr2) as InputStrDelegate;

            InputStrDelegate? delInStrMC1 = delInStr1 + delInStr2;
            delInStrMC1 = delInStrMC1 + delInStr3;
            delInStrMC1 = delInStrMC1 - delInStr2;

            InputStrDelegate? delInStrMC2 = delInStr1;
            delInStrMC2 += delInStr2;
            delInStrMC2 += delInStr3;
            delInStrMC2 -= delInStr2;
            #endregion

            #region 委托强类型
            //无返回类型委托
            Action action = () =>
            {
                Console.WriteLine("委托强类型：Action");
            };
            Action<string> actionInStr = (p) =>
            {
                Console.WriteLine("委托强类型：Action" + " 参数：" + p);
            };

            //有返回类型委托
            Func<int> func = () =>
            {
                Console.WriteLine("委托强类型：Func");
                return 0;
            };
            Func<string, int> funcInStr = (p) =>
            {
                Console.WriteLine("委托强类型：Func" + " 参数：" + p);
                return 0;
            };

            //其他委托
            Predicate<int> predicate = (p) =>
            {
                Console.WriteLine("委托强类型：Predicate" + " 参数：" + p);
                return p > 0;
            };
            Comparison<int> comparison = (x, y) =>
            {
                Console.WriteLine("委托强类型：Comparison" + " 参数x：" + x + " 参数y：" + y);
                return x - y;
            };
            Converter<int, string> converter = (p) =>
            {
                Console.WriteLine("委托强类型：Converter" + " 参数：" + p);
                return p.ToString();
            };
            #endregion

            #region 委托可变性
            //返回类型协变
            OutputObjDelegate delOutObjOut = MyPrint.StaticReturnStr;

            //参数类型逆变
            InputStrDelegate delInStrIn = MyPrint.StaticPrintObj;
            #endregion

            Console.ReadKey();
        }
    }
}