<Query Kind="Program" />

void Main()
{
	var lazy = new Lazy<int?>(() => 1);
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

public A 
{
	int a;
}
