using UnityEngine;
using System.Collections;

public static class Vector3Roz
{
	public static Vector3 RandPoint (this Vector3 t, Vector3 a, Vector3 b)
	{
		return t = new Vector3 (Random.Range (a.x, b.x), Random.Range (a.y, b.y), Random.Range (a.y, b.y));
	}	
}
