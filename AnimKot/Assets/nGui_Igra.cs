using UnityEngine;
using System.Collections;

public class nGui_Igra : MonoBehaviour
{

	public void Igra ()
	{
		GameObject.Find ("Yakor").GetComponent<nGUI_Trigger> ().menu = false;
	}

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
