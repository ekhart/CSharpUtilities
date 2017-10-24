<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
GameObject FindInactive(GameObject gameObject, string name)
{
	return gameObject.GetComponentsInChildren<Transform>(includeInactive: true)
	    .FirstOrDefault(_ => _.name == name)
	    .gameObject;
}