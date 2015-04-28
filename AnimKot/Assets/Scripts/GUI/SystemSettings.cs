using UnityEngine;
using System.Collections;

public class SystemSettings : MonoBehaviour
{

	public GUISkin mYskin;
	
	void OnGUI ()
	{
		GUI.skin = mYskin;
		GUI.Box (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 150, 200, 300), "Настройки системы");
		
		if (GUI.Button (new Rect (Screen.width / 2 - 75, Screen.height / 2 - 90, 150, 40), "Настройки")) {
			gameObject.GetComponent<Settings> ().enabled = true;
			gameObject.GetComponent<SystemSettings> ().enabled = false;
		}
		if (GUI.Button (new Rect (Screen.width / 2 - 75, Screen.height / 2 - 30, 150, 40), "Ввод")) {

		}
		if (GUI.Button (new Rect (Screen.width / 2 - 75, Screen.height / 2 + 30, 150, 40), "Видео")) {

		}
		if (GUI.Button (new Rect (Screen.width / 2 - 75, Screen.height / 2 + 90, 150, 40), "Аудио")) {
            
		}
	}
}
