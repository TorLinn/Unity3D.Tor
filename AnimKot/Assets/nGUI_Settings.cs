using UnityEngine;
using System.Collections;

public class nGUI_Settings : MonoBehaviour
{

	public GameObject mai;
	public GameObject set;

	public void Sett ()
	{
		mai.SetActive (false);
		set.SetActive (true);
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
