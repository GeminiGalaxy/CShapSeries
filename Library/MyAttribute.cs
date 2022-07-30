namespace Library
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
    public class MyTestAttribute : Attribute
    {
        public string? Name { get; set; }

        public MyTestAttribute()
        {

        }

        public MyTestAttribute(int para)
        {

        }
    }

    [MyTest(Name = "MyClass")]
    public class MyClassBase
    {
        private string? _strField;

        [MyTest(0)]
        public int IntProperty { get; set; }


        public string? StrProperty
        {
            [return: MyTest]
            get { return _strField; }
            [param: MyTest]
            set { _strField = value; }
        }

        [return: MyTest]
        public string? MyClassFunction([MyTest] int para)
        {
            return null;
        }
    }

    public class MyClass : MyClassBase
    {

    }
}
