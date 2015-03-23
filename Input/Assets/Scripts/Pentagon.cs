using UnityEngine;
using System.Collections;

public class Pentagon : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if ((Input.GetKey(KeyCode.RightShift) != true) && (Input.GetKey(KeyCode.RightAlt) != true)) {
			transform.position += new Vector3 (Input.GetAxis("Horizontall")/10, Input.GetAxis("Verticall")/10, 0);
			
		}
		if (Input.GetKey(KeyCode.RightShift)) {
			transform.position += new Vector3 (Input.GetAxis("Horizontall")/2, Input.GetAxis("Verticall")/2, 0);
			
		}
		if (Input.GetKey(KeyCode.RightAlt)) {
			transform.position += new Vector3 (Input.GetAxis("Horizontall")/100, Input.GetAxis("Verticall")/100, 0);
			
		}
	
	}
}
