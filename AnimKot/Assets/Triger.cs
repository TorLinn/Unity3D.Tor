using UnityEngine;
using System.Collections;

public class Triger : MonoBehaviour
{
	public bool menu = false;
	public GameObject gMenu;

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) {
			menu = !menu;
			if (menu == false) {
				gMenu.GetComponent<Menu> ().enabled = true;
				gMenu.GetComponent<Settings> ().enabled = false;
				gMenu.GetComponent<SystemSettings> ().enabled = false;
				gMenu.GetComponent<GameSettings> ().enabled = false;
			}
		}
		gMenu.SetActive (menu);
	}
}
