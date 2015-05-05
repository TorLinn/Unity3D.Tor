using UnityEngine;
using System.Collections;

public class Damag : MonoBehaviour
{

	void OnTriggerEnter (Collider col)
	{
		Application.LoadLevel (0);
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
