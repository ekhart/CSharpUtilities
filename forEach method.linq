<Query Kind="Program" />

void Main()
{
	var @as = new List<A>();
	@as.Add(new A());
	
	// standard way
	@as.ForEach(_ => _.B());
	// we need every time do _ => _.#()
	// where # is just name of method
	
	// we want @as.ForEach(B); - looks best
	// 1. solution - method in this class
	@as.ForEach(B);
	// works but we need to define in every class such method
	// and we shouldn't - because it's not belong to
	
	// 2. solution - static method in proper class
	@as.ForEach(A.B);
	// better, but tedious
	// we need to define static/class method for all object/instance methods
	// just to forward method
}

// Define other methods and classes here
class A
{
	public void B() 
	{
		Console.WriteLine("this.B()");
	}

	// 2. solution
	public static void B(A a)
	{
		a.B();
	}
}

// 1. solution
void B(A a) 
{
	a.B();
}