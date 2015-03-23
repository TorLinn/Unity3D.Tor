using UnityEngine;
using System.Collections;

public class RazmMouse : MonoBehaviour {

	void OnMouseOver () {
		if (Input.GetMouseButton(0)) {
			transform.localScale += new Vector3(0.1f, 0.1f, 0); 
		}
		if (Input.GetMouseButton(1)) {
			transform.localScale -= new Vector3(0.1f, 0.1f, 0); 
		}
		if (Input.GetMouseButtonDown(2)) {
			transform.localScale = new Vector3(1f, 1f, 1f); 
		}

		
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
}
