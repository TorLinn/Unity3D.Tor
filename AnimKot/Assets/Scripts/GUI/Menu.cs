using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour
{
	public GUISkin mYskin;

	void OnGUI ()
	{
		GUI.skin = mYskin;
		GUI.Box (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 150, 200, 300), "Кот Аноним");

		if (GUI.Button (new Rect (Screen.width / 2 - 75, Screen.height / 2 - 70, 150, 40), "Игра")) {
			GameObject.Find ("Gui").GetComponent<Triger> ().menu = false;
		}
		if (GUI.Button (new Rect (Screen.width / 2 - 75, Screen.height / 2, 150, 40), "Установки")) {
			gameObject.GetComponent<Menu> ().enabled = false;
			gameObject.GetComponent<Settings> ().enabled = true;
		}
		if (GUI.Button (new Rect (Screen.width / 2 - 75, Screen.height / 2 + 70, 150, 40), "Выход")) {
			Application.Quit ();
		}
	}
}
