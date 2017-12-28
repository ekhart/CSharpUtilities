<Query Kind="Program" />

void Main()
{
	_.Array("test").Dump();
	_.Identity(1).Dump();
	
	_.Array("test").Select(_.Identity).Dump();
}

// Define other methods and classes here
public static class _
{
    public static T Identity<T>(T t)
    {
        return t;
    }
	
	//    public static Func<T, bool> Identity<T>(T t)
//    {
//        return _ => _;
//    }

    public static T[] Array<T>(params T[] @objects)
    {
        return @objects;
    }
	
	public static U Value<T, U>(KeyValuePair<T, U> pair)
    {
        return pair.Value;
    }
	
	public static T Key<T, U>(KeyValuePair<T, U> pair)
    {
        return pair.Key;
    }
}