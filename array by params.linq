<Query Kind="Program" />

void Main()
{
	var normal = new[] { "a", "b" };
	var pretty = array("a", "b");
	
	// var normal = new[]{"a", "b"};
	// var pretty = array("a", "b");
	// similar number of chars - equal, but more readable
		
	normal.Dump();
	pretty.Dump();
	
	array("a", "b").Dump();
	array(1, 2).Dump();
}

// Define other methods and classes here
private T[] array<T>(params T[] buttonNames)
{
	return buttonNames;
}