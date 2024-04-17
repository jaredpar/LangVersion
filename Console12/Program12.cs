using System;
using System.ComponentModel;
using Util12;
public class Program
{
    public static void Main(string[] args)
    {
        DynamicUtil.M1(42);

        // Does a dynamic conversion on the result.
        int z = DynamicUtil.M2(42);

        // Does a dynamic conversion on the result.
        string x = DynamicUtil.M3();
    }

    static readonly ROStruct s_roStruct = new ROStruct();

    public static void ReadOnlyMembers()
    {
        s_roStruct.M1();
        s_roStruct.M2();
    }
    // Definitions of features that fail to compile.
#if false

    public static void M1(dynamic d) { }
    public static dynamic M2(dynamic d) { }

#endif
}