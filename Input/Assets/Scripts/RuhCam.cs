﻿using UnityEngine;
using System.Collections;

public class RuhCam : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (0, 0, Input.GetAxis ("Mouse ScrollWheel"));
		if (Input.GetMouseButton(0)) {
			transform.position += new Vector3 (Input.GetAxis("Mouse X")/10, Input.GetAxis("Mouse Y")/10, 0);
		}
	}
}