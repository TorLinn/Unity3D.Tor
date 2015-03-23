﻿using UnityEngine;
using System.Collections;

public class RGB : MonoBehaviour {
	public Transform R, G, B;
	float distR, distG, distB, summ;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0)) {
			transform.position += new Vector3 (Input.GetAxis("Mouse X")/2, Input.GetAxis("Mouse Y")/2, 0);
		}
		distR = Vector3.Distance (R.position, transform.position);
		distG = Vector3.Distance (G.position, transform.position);
		distB = Vector3.Distance (B.position, transform.position);
		summ = distR + distG + distB;
		print (distR+" "+distG+" "+distB);
		if ((distR < distG) &&(distR < distB)) {
			transform.GetComponent<SpriteRenderer> ().color = new Color (1f,0,0);
		}
		else if ((distG < distR) && (distG < distB)) {
			transform.GetComponent<SpriteRenderer> ().color = new Color (0,1f,0);
		}
		else if ((distB < distR) && (distB < distG)) {
			transform.GetComponent<SpriteRenderer> ().color = new Color (0,0,1f);
		}
		//transform.GetComponent<SpriteRenderer> ().color = new Color /*(0,1f,0);*/(distR/summ, distG/summ, distB/summ);

	
	}
}
