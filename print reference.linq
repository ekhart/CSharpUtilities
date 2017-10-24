<Query Kind="Program">
  <Reference>D:\ohsir\branches\Switch\OhSir\Library\UnityAssemblies\UnityEngine.dll</Reference>
</Query>

void Main()
{
	Print(null).Dump();
	Print(new Double()).Dump();
}

// Define other methods and classes here
string Print(object @object) 
{
	return @object == null ? "null" : @object.ToString();
}

void Log(object @object) 
{
	Debug.Log(Print(@object));
}