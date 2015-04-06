using UnityEngine;
using System.Collections;

public class Golda : MonoBehaviour {
	public GameObject pers;

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.name == "Kot") {
			col.GetComponent<Ruh>().Gold += 10;
			Destroy(gameObject);
		}	

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
