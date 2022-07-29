using System;

namespace Library
{
    /// <summary>
    /// 泛型委托
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="para"></param>
    public delegate void InputGenericsDelegate<T>(T para);

    /// <summary>
    /// 协变委托
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public delegate T CovariantDelegate<out T>();

    /// <summary>
    /// 逆变委托
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="para"></param>
    public delegate void ContravariantDelegate<in T>(T para);

    /// <summary>
    /// 泛型接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IMyGenerics<T>
        where T : class
        //where T : class, new()
        /* 泛型约束
         * 类型约束
         *     struct(不可空值类型) class(不可空引用类型) class?(可空引用类型)
         *     unmanaged(不可空非托管类型) new()(具有公共无参构造函数)
         *     notnull(不可为空)
         * 继承约束
         *     基类名(继承自基类且不可为空) 基类名?(继承自基类且可为空)
         *     接口名(实现接口且不可为空) 接口名?(实现接口且可为空)
         *     类型参数(继承自传递的类型参数约束)
         */
    {

    }

    /// <summary>
    /// 泛型类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MyGenerics<T> : IMyGenerics<T>
        where T : class
        //where T : class, new()
    {
        /// <summary>
        /// 泛型方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="para"></param>
        public void GenericsMethod<TPara>(TPara para)
        {
            Console.WriteLine("泛型方法<TPara>：" + para);
        }

        /// <summary>
        /// 泛型方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="para"></param>
        public TResult? GenericsMethod<TPara, TResult>(TPara para)
        {
            Console.WriteLine("泛型方法<TPara,TResult>：" + para);
            return default(TResult);//TResult默认值
        }

        /// <summary>
        /// 泛型方法(装箱)
        /// </summary>
        /// <typeparam name="TPara"></typeparam>
        /// <param name="para"></param>
        /// <returns></returns>
        public object? GenericsBoxMethod<TPara>(TPara para)
        {
            return para;
        }
    }
}
