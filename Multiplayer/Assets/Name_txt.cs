using UnityEngine;
using System.Collections;

public class Name_txt : MonoBehaviour
{
	public bool showBar;			//тригер для показа хитбара
	public GameObject mon;	
	public string nam = "Player";

	// Use this for initialization
	void Start ()
	{

	}
	
	// рисование бара через GUI
	void OnGUI ()
	{
		Vector3 screenPos = Camera.main.WorldToScreenPoint (mon.transform.position);
		GUI.Label (new Rect (screenPos.x - 25, Camera.main.pixelRect.yMax - screenPos.y - 20, 100f, 20f), nam);
	}
}
