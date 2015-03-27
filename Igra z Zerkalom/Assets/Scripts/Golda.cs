using UnityEngine;
using System.Collections;

public class Golda : MonoBehaviour {
	public GameObject pla1, pla2;
	
	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.name == "pers1") {
			col.GetComponent<Player1>().POint += 10;
			Destroy(gameObject);
		}
		if (col.name == "pers2") {
			col.GetComponent<Player2>().POint += 10; 
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
