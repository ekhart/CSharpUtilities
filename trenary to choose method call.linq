<Query Kind="Program" />

void Main()
{
	var value = false;
	// (value ? Enable : Disable)(); // fail
	// "Error 13 Type of conditional expression cannot be determined because there is no implicit conversion between 'method group' and 'method group'"
	
	// Using conditional (?:) operator for method selection in C# (3.0)?
	// https://stackoverflow.com/questions/5186394/using-conditional-operator-for-method-selection-in-c-sharp-3-0
	
	(value ? (Action) Enable : Disable)(); // works!
}

// Define other methods and classes here
void Enable()
{
	Console.WriteLine("Enable");
}

void Disable()
{
	Console.WriteLine("Disable");
}