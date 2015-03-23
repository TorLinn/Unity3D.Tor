using UnityEngine;
using System.Collections;

public class Konus : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if ((Input.GetKey(KeyCode.LeftShift) != true) && (Input.GetKey(KeyCode.LeftAlt) != true)) {
			transform.position += new Vector3 (Input.GetAxis("Horizontal")/10, Input.GetAxis("Vertical")/10, 0);
			
		}
		if (Input.GetKey(KeyCode.LeftShift)) {
			transform.position += new Vector3 (Input.GetAxis("Horizontal")/2, Input.GetAxis("Vertical")/2, 0);
			
		}
		if (Input.GetKey(KeyCode.LeftAlt)) {
			transform.position += new Vector3 (Input.GetAxis("Horizontal")/100, Input.GetAxis("Vertical")/100, 0);
			
		}

	}
}
