using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
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

    public static void PrimaryConstructors()
    {
        PrimaryConstructor c = new PrimaryConstructor(42);
        Console.WriteLine(c.Value);
    }

    public static void CovariantReturn()
    {
        CovariantReturn b = new CovariantReturn();
        string s = b.M1();
    }

    public static void CheckedOperators()
    {
        BigInt b = new BigInt();
#if false
        checked {
            int x = b + b;
        }
#endif
    }

    static readonly ROStruct s_roStruct = new ROStruct();

    public static void ReadOnlyMembers()
    {
        s_roStruct.M1();
        s_roStruct.M2();
    }

    public static void BetterOverloadCandidatesConsumption()
    {
#if false
        BetterOverloadCandidates.M(null);
#endif
    }

    // Definitions of features that fail to compile.
#if false

    public static void M1(dynamic d) { }
    public static dynamic M2(dynamic d) { }
    public static void M3<T>(T t) { }

#endif
}