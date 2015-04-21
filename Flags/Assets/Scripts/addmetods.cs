using UnityEngine;
using System.Collections;

public static class addmetods
{
	public static void setX (this Transform t, float x)
	{
		t.position = new Vector3 (x, t.position.y, t.position.z);
	}
	public static void setY (this Transform t, float y)
	{
		t.position = new Vector3 (t.position.x, y, t.position.z);
	}
	public static void setZ (this Transform t, float z)
	{
		t.position = new Vector3 (t.position.x, t.position.y, z);
	}

	public static void setX (this Transform t, string s, float x)
	{
		t.localPosition = new Vector3 (x, t.localPosition.y, t.localPosition.z);
	}
	public static void setY (this Transform t, string s, float y)
	{
		t.localPosition = new Vector3 (t.localPosition.x, y, t.localPosition.z);
	}
	public static void setZ (this Transform t, string s, float z)
	{
		t.localPosition = new Vector3 (t.localPosition.x, t.localPosition.y, z);
	}
}
