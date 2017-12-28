<Query Kind="Program" />

void Main()
{
	var empty = (string[]) null;
	var array = new[] { "yes" };
	var more = new[] { "yes", "no" };

	IfIs(array, _ => _[0].Dump());
	//IfIs(null, _ => ((string[])_)[0].Dump());
	
	IfIs(empty, _ => _[0].Dump());
	
	array.IfIs(_ => _[0].Dump());
	
	empty.NullToString().Dump();
	array.NullToString().Dump();
	
	empty.ArrayToString().Dump();
	array.ArrayToString().Dump();
	more.ArrayToString().Dump();
}

private static void IfIs<T>(T @object, Action<T> action)
{
    if (@object != null)
    {
        action(@object);
    }
}

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
	
	public static string ArrayToString<T>(this IEnumerable<T> enumerable)
    {
        return string.Format("[{0}]", enumerable == null ? string.Empty : string.Join(", ", enumerable.Select(ToString).ToArray()));
    }
	
	private static string ToString<T>(T @object)
	{
		return @object.ToString();
	}
	
	// log method & it's parameters values	
	
	// debug.log - ~ vs macro
	
	public static void Times(this int count, Action action)
    {
        for (var i = 0; i < count; i++)
        {
            action();
        }
    }

    public static void Times(this int count, Action<int> action)
    {
        for (var i = 0; i < count; i++)
        {
            action(i);
        }
    }
}