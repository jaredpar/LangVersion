using System;
using System.ComponentModel;
using Util12;
public class Program
{
    public static void Main(string[] args)
    {

    }

    public static void Dynamic()
    {
        DynamicUtil.M1(42);

        // Does a dynamic conversion on the result.
        int z = DynamicUtil.M2(42);

        // Does a dynamic conversion on the result.
        string x = DynamicUtil.M3();
    }

    public static void Generics()
    {
        GenericUtil.M1("hello world");
        GenericUtil.M1(null);
        GenericUtil.M2("hello world");
        object o = GenericUtil.M3();
        string o2 = GenericUtil.M3();
    }

    // Definitions of features that fail to compile.
#if false

    public static void M1(dynamic d) { }
    public static dynamic M2(dynamic d) { }
    public static void M3<T>(T t) { }

#endif
}