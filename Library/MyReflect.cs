namespace Library
{
    public class PrivateMyReflect
    {
        /// <summary>
        /// 私有构造方法
        /// </summary>
        private PrivateMyReflect()
        {

        }
    }

    public class MyReflect
    {
        /// <summary>
        /// 私有字段
        /// </summary>
        private int _intField;

        /// <summary>
        /// 公共字段
        /// </summary>
        public int intField;

        /// <summary>
        /// 私有属性
        /// </summary>
        private int _IntProperty { get; set; }

        /// <summary>
        /// 公共属性
        /// </summary>
        public int IntProperty { get; set; }

        /// <summary>
        /// 私有方法
        /// </summary>
        private void PrivateFunction()
        {

        }

        /// <summary>
        /// 公共方法
        /// </summary>
        /// <returns></returns>
        public void PublicFunction()
        {

        }

        /// <summary>
        /// 公共方法
        /// </summary>
        /// <returns></returns>
        public string? PublicFunction2()
        {
            return null;
        }

        /// <summary>
        /// 公共方法(重载)
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public string PublicFunction2(int para)
        {
            return para.ToString();
        }

        /// <summary>
        /// 公共方法(包含in/out/ref关键字)
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public void InOutRefFunction(in string paraIn, out string paraOut, ref string paraRef)
        {
            paraOut = "参数paraOut";
            paraRef = "参数paraRef(修改后)";
        }
    }

    public class MyReflect<TPara>
    {
        /// <summary>
        /// 泛型方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public void GenericsFunction<T>()
        {

        }

        /// <summary>
        /// 泛型方法(重载)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public void GenericsFunction<T, T1>(T para)
        {

        }
    }
}
