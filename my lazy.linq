<Query Kind="Program" />

void Main()
{
	// var lazy = new Lazy<int>(() => 1); // T should be class
	
	var lazy = new Lazy<A>(() => new A { a = 1 });
	lazy.Value.Dump();
}

// Define other methods and classes here
public class Lazy<T> where T : class 
{
    private T _value;
    
    private readonly Func<T> _getValue;

    public T Value
    {
        get { return _value ?? (_value = _getValue()); }
    }

    public Lazy(Func<T> getValue)
    {
        this._getValue = getValue;
    }
}

public class A 
{
	public int a;
}
