using UnityEngine;
using System.Collections;

public class Monetka : MonoBehaviour {

	void OnTriggerEnter (Collider col) {
		if (col.tag == "Player") {
			Destroy(gameObject);
			col.transform.GetComponent<Play>().Score +=1;
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0,4,0));
	
	}
}
