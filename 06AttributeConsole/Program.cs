using Library;
using System.Reflection;

namespace AttributeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 获取全部特性
            Type type = typeof(MyClass);
            object[]? attributes = type.GetCustomAttributes(true);//获取全部特性
            if (type.IsDefined(typeof(MyTestAttribute), true))//判断是否存在指定类型的特性
            {
                //获取指定类型的全部特性
                attributes = type.GetCustomAttributes(typeof(MyTestAttribute), true);
            }
            #endregion

            #region 获取成员特性
            PropertyInfo? propertyInfo = type.GetProperty("IntProperty");
            attributes = propertyInfo?.GetCustomAttributes(true);//获取属性全部特性
            if ((propertyInfo != null) && propertyInfo.IsDefined(typeof(MyTestAttribute), true))//判断是否存在指定类型的特性
            {
                //获取指定类型的全部特性
                attributes = propertyInfo.GetCustomAttributes(typeof(MyTestAttribute), true);
            }
            #endregion

            Console.ReadKey();
        }
    }
}