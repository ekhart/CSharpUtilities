<Query Kind="Program" />

void Main()
{
	var empty = (string[]) null;
	var array = new[] { "yes" };

	IfIs(array, _ => _[0].Dump());
	//IfIs(null, _ => ((string[])_)[0].Dump());
	
	IfIs(empty, _ => _[0].Dump());
	
	array.IfIs(_ => _[0].Dump());
	
	empty.NullToString().Dump();
	array.NullToString().Dump();
}

// Define other methods and classes here
private static void IfIs<T>(T @object, Action<T> action)
{
    if (@object != null)
    {
        action(@object);
    }
}
//private static void IfIs(object @object, Action<object> action)
//{
//    if (@object != null)
//    {
//        action(@object);
//    }
//}

public static class ObjectExtensions
{
	public static void IfIs<T>(this T @object, Action<T> action)
	{
	    if (@object != null)
	    {
	        action(@object);
	    }
	}
	
	public static string NullToString<T>(this T @object)
	{
		return @object == null ? "null" : @object.ToString();
	}
}