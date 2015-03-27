using UnityEngine;
using System.Collections;

public class Yaschik : MonoBehaviour {
	public GameObject pul;

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Bullets") {
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
