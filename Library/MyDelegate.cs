namespace Library
{
    /// <summary>
    /// 参数类型为object的委托类型
    /// </summary>
    /// <param name="objPara"></param>
    public delegate void InputObjDelegate(object objPara);

    /// <summary>
    /// 参数类型为string的委托类型
    /// </summary>
    /// <param name="strPara"></param>
    public delegate void InputStrDelegate(string strPara);

    /// <summary>
    /// 参数类型为int的委托类型
    /// </summary>
    /// <param name="intPara"></param>
    public delegate void InputIntDelegate(int intPara);

    /// <summary>
    /// 返回类型为object的委托类型
    /// </summary>
    /// <returns></returns>
    public delegate object OutputObjDelegate();

    public class MyPrint
    {
        /// <summary>
        /// 打印object静态方法
        /// </summary>
        /// <param name="objPara"></param>
        public static void StaticPrintObj(object objPara)
        {
            Console.WriteLine("打印object静态方法：" + objPara);
        }

        /// <summary>
        /// 打印string静态方法
        /// </summary>
        /// <param name="strPara"></param>
        public static void StaticPrintStr(string strPara)
        {
            Console.WriteLine("打印string静态方法：" + strPara);
        }

        /// <summary>
        /// 打印int静态方法
        /// </summary>
        /// <param name="strPara"></param>
        public static void StaticPrintInt(int intPara)
        {
            Console.WriteLine("打印int静态方法：" + intPara);
        }

        /// <summary>
        /// 返回类型为string静态方法
        /// </summary>
        /// <returns></returns>
        public static string StaticReturnStr()
        {
            Console.WriteLine("返回string静态方法");
            return "返回string静态方法";
        }

        /// <summary>
        /// 打印string方法
        /// </summary>
        /// <param name="strPara"></param>
        public void PrintStr(string strPara)
        {
            Console.WriteLine("打印string方法：" + strPara);
        }
    }
}
