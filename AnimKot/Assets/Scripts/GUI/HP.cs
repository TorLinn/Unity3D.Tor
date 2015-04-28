using UnityEngine;
using System.Collections;

public class HP : MonoBehaviour
{

	public GUISkin mYskin;

	void OnGUI ()
	{
		GUI.skin = mYskin;
		GUI.Box (new Rect (20, 20, 100, 95), "Status");
		GUI.Label (new Rect (20, 55, 100, 30), "HP = " + Ruh.pat.HP);
		GUI.Label (new Rect (20, 75, 100, 30), "Gold = " + Ruh.pat.Gold);
	}
}
