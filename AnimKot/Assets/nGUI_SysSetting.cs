using UnityEngine;
using System.Collections;

public class nGUI_SysSetting : MonoBehaviour
{

	public GameObject mai;
	public GameObject set;
	
	public void gSet ()
	{
		mai.SetActive (true);
		set.SetActive (false);
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
