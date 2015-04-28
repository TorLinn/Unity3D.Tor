using UnityEngine;
using System.Collections;

public class Settings : MonoBehaviour
{

	public GUISkin mYskin;
	
	void OnGUI ()
	{
		GUI.skin = mYskin;
		GUI.Box (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 150, 200, 300), "Настройки");
		
		if (GUI.Button (new Rect (Screen.width / 2 - 75, Screen.height / 2 - 70, 150, 40), "Главное меню")) {
			gameObject.GetComponent<Menu> ().enabled = true;
			gameObject.GetComponent<Settings> ().enabled = false;
		}
		if (GUI.Button (new Rect (Screen.width / 2 - 75, Screen.height / 2, 150, 40), "Игровой процесс")) {
			gameObject.GetComponent<GameSettings> ().enabled = true;
			gameObject.GetComponent<Settings> ().enabled = false;
		}
		if (GUI.Button (new Rect (Screen.width / 2 - 75, Screen.height / 2 + 70, 150, 40), "Настройки системы")) {
			gameObject.GetComponent<SystemSettings> ().enabled = true;
			gameObject.GetComponent<Settings> ().enabled = false;
		}
	}
}
