using UnityEngine;
using System.Collections;

public class nGUI_Trigger : MonoBehaviour
{

	public bool menu = false;
	public GameObject mainn;
	public GameObject main_nGui;
	public GameObject main_Setting;
	public GameObject main_SetGame;
	public GameObject main_SetSys;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) {
			menu = !menu;
			if (menu == true) {
				main_nGui.SetActive (true);
				main_Setting.SetActive (false);
				main_SetGame.SetActive (false);
				main_SetSys.SetActive (false);
			}
		}
		mainn.SetActive (menu);
	}
}
