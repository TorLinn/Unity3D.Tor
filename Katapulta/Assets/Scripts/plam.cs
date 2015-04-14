using UnityEngine;
using System.Collections;

public class plam : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.parent.GetComponent<Yadro>().daged == true) {
			gameObject.GetComponent<ParticleSystem>().enableEmission = false;
		}
	}
}
