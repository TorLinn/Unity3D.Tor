using UnityEngine;
using System.Collections;

public class Fin : MonoBehaviour {
	public GameObject play1, play2;

	void OnTriggerEnter2D (Collider2D col)
	{
		col.tag = "Finish";
		if (play1.tag == "Finish") {
			print ("Bingo!!!");
		}
	}
	void OnTriggerExit2D (Collider2D col)
	{
		col.tag = "Player";
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
