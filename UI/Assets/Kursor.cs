using UnityEngine;
using System.Collections;

public class Kursor : MonoBehaviour
{

	public bool kliked = false;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position = Input.mousePosition + new Vector3 (-50f, 0, 0);
	}
}
