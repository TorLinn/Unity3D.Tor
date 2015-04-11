using UnityEngine;
using System.Collections;

public class Yadro : MonoBehaviour {
	Rigidbody2D person;

	// Use this for initialization
	void Start () {
		person = GetComponent<Rigidbody2D> ();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			person.AddForce (new Vector2 (1000f, 0f));
		}
	}
}
