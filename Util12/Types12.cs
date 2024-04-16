namespace Util12;

public class DynamicUtil
{
    public static void M1(dynamic d) { }
    public static dynamic M2(dynamic d) => "M2";
    public static dynamic M2(dynamic d, dynamic d2) => "M2";
    public static dynamic M3() => 42;
}
