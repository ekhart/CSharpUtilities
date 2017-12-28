<Query Kind="Program">
  <Reference>&lt;ProgramFilesX64&gt;\Unity 2017.2.0f3\Editor\Data\Managed\UnityEditor.dll</Reference>
  <Reference>&lt;ProgramFilesX64&gt;\Unity 2017.2.0f3\Editor\Data\Managed\UnityEngine.dll</Reference>
  <Namespace>UnityEngine</Namespace>
</Query>

void Main()
{
	// var go = new GameObject("go"); // can't be tested in Linq, works only on running game
}

// class @ { } // cant
class @_ { } // could be
// class @_@ { } // cant be xd

// Define other methods and classes here
public static class ObjectExt
{

    public static void SetInactive(this GameObject gameObject)
    {
        gameObject.SetActive(false);
    }

    public static void SetActive(this GameObject gameObject)
    {
        gameObject.SetActive(true);
    }

    public static void IfIs<T>(this T behaviour, Action<T> action) where T : MonoBehaviour
    {
        if (behaviour)
        {
            action(behaviour);
        }
    }
	
	public static GameObject FindInactive(this GameObject gameObject, string name)
	{
		return gameObject.GetComponentsInChildren<Transform>(includeInactive: true)
		    .FirstOrDefault(_ => _.name == name)
		    .gameObject;
	}
}