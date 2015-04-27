using UnityEngine;
using System.Collections;

public class Toggle : MonoBehaviour
{
	public GUISkin mYskin;
	public bool z1 = true, z2 = false, z3 = false;

	void OnGUI ()
	{
		GUI.skin = mYskin;
		if (z1 == true) {
			z2 = false;
			z3 = false;
		}
		if (z2 == true) {
			z1 = false;
			z3 = false;
		}
		if (z3 == true) {
			z1 = false;
			z2 = false;
		}
		z1 = GUI.Toggle (new Rect (300, 100, 80, 20), z1, "1 Vibor");
		z2 = GUI.Toggle (new Rect (300, 120, 80, 20), z2, "2 Vibor");
		z3 = GUI.Toggle (new Rect (300, 140, 80, 20), z3, "3 Vibor");
	}
	void Update ()
	{

	}
}
