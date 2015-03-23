using UnityEngine;
using System.Collections;

public class Ertch : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 1f, 0); // Поворот на 1 градус
	
		if ((Input.GetKey(KeyCode.LeftShift) != true) && (Input.GetKey(KeyCode.LeftAlt) != true)) {
			transform.position += new Vector3 (Input.GetAxis("Horizontall")/10, Input.GetAxis("Verticall")/10, 0);
			
		}
		if (Input.GetKey(KeyCode.LeftShift)) {
			transform.position += new Vector3 (Input.GetAxis("Horizontall")/2, Input.GetAxis("Verticall")/2, 0);
			
		}
		if (Input.GetKey(KeyCode.LeftAlt)) {
			transform.position += new Vector3 (Input.GetAxis("Horizontall")/100, Input.GetAxis("Verticall")/100, 0);
			
		}
	}
}
