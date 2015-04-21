using UnityEngine;
using System.Collections;

public static class InputRoz
{
	public static bool GetKeyDownD (this Input t, string a, string b)
	{
		if (Input.GetKeyDown (a) && Input.GetKeyDown (b)) {
			return true;
		}
		return false;
	}	
	public static bool GetKeyD (this Input t, string a, string b)
	{
		if (Input.GetKey (a) && Input.GetKey (b)) {
			return true;
		}
		return false;
	}
	public static bool GetKeyUpD (this Input t, string a, string b)
	{
		if (Input.GetKeyUp (a) && Input.GetKeyUp (b)) {
			return true;
		}
		return false;
	}

	public static bool GetKeyDownD (this Input t, KeyCode a, KeyCode b)
	{
		if (Input.GetKeyDown (a) && Input.GetKeyDown (b)) {
			return true;
		}
		return false;
	}	
	public static bool GetKeyD (this Input t, KeyCode a, KeyCode b)
	{
		if (Input.GetKey (a) && Input.GetKey (b)) {
			return true;
		}
		return false;
	}
	public static bool GetKeyUpD (this Input t, KeyCode a, KeyCode b)
	{
		if (Input.GetKeyUp (a) && Input.GetKeyUp (b)) {
			return true;
		}
		return false;
	}
}
