﻿using UnityEngine;
using System.Collections;

public class GameSettings : MonoBehaviour
{

	public GUISkin mYskin;
	
	void OnGUI ()
	{
		GUI.skin = mYskin;
		GUI.Box (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 150, 200, 300), "Настройки игры");
		
		if (GUI.Button (new Rect (Screen.width / 2 - 75, Screen.height / 2 - 70, 150, 40), "Настройки")) {
			gameObject.GetComponent<Settings> ().enabled = true;
			gameObject.GetComponent<GameSettings> ().enabled = false;
		}
		if (GUI.Button (new Rect (Screen.width / 2 - 75, Screen.height / 2, 150, 40), "Сложность")) {

		}
		if (GUI.Button (new Rect (Screen.width / 2 - 75, Screen.height / 2 + 70, 150, 40), "Кровь")) {

		}
	}
}
