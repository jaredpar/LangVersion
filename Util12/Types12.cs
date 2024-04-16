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
