using System.Reflection.Metadata.Ecma335;

namespace Util12;

public class DynamicUtil
{
    public static void M1(dynamic d) { }
    public static dynamic M2(dynamic d) => "M2";
    public static dynamic M2(dynamic d, dynamic d2) => "M2";
    public static dynamic M3() => 42;
}

public class GenericUtil
{
    public static void M1(GenericType<string> t) { }
    public static void M2<T>(T t) { }
    public static GenericType<string> M3() => new();
}

public class GenericType<T>
{
    public static implicit operator GenericType<T>(string o) => new GenericType<T>();
    public static implicit operator string(GenericType<T> o) => "";
}

public class PrimaryConstructor(int value)
{
    public int Value => value;
}

public abstract class CovariantReturnBase
{
    public abstract object M1();
}

public class CovariantReturn : CovariantReturnBase
{
    public override string M1() => "";
}

public class BigInt
{
    public static int operator+(BigInt a, BigInt b) => 0;
    public static int operator checked +(BigInt a, BigInt b) => 1;
}

public struct ROStruct
{
    public void M1() { }
    public readonly void M2() { }
}

