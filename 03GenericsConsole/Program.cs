using Library;

namespace GenericsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 泛型调用
            //泛型委托
            InputGenericsDelegate<int> inputGenericsDelegate = (p) => { Console.WriteLine("泛型委托"); };

            //泛型类
            MyGenerics<string> myGenerics = new MyGenerics<string>();

            //泛型方法
            myGenerics.GenericsMethod<string>("泛型方法");
            myGenerics.GenericsMethod<string, int>("泛型方法");
            #endregion

            #region 泛型可变性
            //协变
            CovariantDelegate<string> covariantDelegateStr = () => { return "协变泛型委托"; };
            CovariantDelegate<object> covariantDelegate = covariantDelegateStr;

            //逆变
            ContravariantDelegate<object> contravariantDelegateObj = (p) => { Console.WriteLine("逆变泛型委托"); };
            ContravariantDelegate<string> contravariantDelegate = contravariantDelegateObj;
            #endregion

            Console.ReadKey();
        }
    }
}