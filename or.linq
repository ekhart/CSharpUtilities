<Query Kind="Program" />

void Main()
{
	var a = new A { Default = "b", Android = "b", C = "c" };
	
	// a.Default == "b" || a.Android == "b" || a.Android == "b"
	// "b".Or(a.Default, a.Android)
	"a".Or(a.Default, a.Android, a.C).Dump();
	
	// a.Default == "b" && a.Android == "b"  && a.C == "b" 
	// "b".And(a.Default, a.Android)
	"b".And(a.Default, a.Android, a.C).Dump();
	
	"b".And(string.Equals, a.Default, a.Android, a.C).Dump();
}

class A 
{
	public string Default;
	public string Android;
	public string C;
}


public static class ObjectExtensions
{
//	public static bool Or<T>(this T @object, params T[] ors) 
//		where T : class // compile
//	{
//		var r = false;
//		
//		foreach (var o in ors)
//		{
//			r |= @object == o;
//		}
//		
//		return r;
//	}
	
	public static bool Or<T>(this T @object, params T[] ors) 
		where T : class // compile https://stackoverflow.com/questions/390900/cant-operator-be-applied-to-generic-types-in-c
	{
		return ors.Aggregate(false, (acc, o) => acc || @object == o);
	}
	
	public static bool Or<T>(this T @object, Func<T, T, bool> p, params T[] ors) 
		where T : class
	{
		return ors.Aggregate(false,  (acc, o) => acc || p(@object, o));
	}
	
	public static bool And<T>(this T @object, params T[] ors) 
		where T : class
	{
		return ors.Aggregate(true, (acc, o) => acc && @object == o);
	}
	
	public static bool And<T>(this T @object, Func<T, T, bool> p, params T[] ors) 
		where T : class
	{
		return ors.Aggregate(false,  (acc, o) => acc && p(@object, o));
	}
	
	// still dont work like a == b || a == c || a == d
	// because it should stop asap if some part is true
}