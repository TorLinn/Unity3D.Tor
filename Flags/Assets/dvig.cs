using UnityEngine;
using System.Collections;

public class dvig : MonoBehaviour {

	public float priskor = 10;
	public float HP = 100;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		gameObject.GetComponent<Rigidbody>().velocity = new Vector3 (Input.GetAxis ("Horizontal")*priskor, 0, Input.GetAxis ("Vertical")*priskor);
	
	}
}
