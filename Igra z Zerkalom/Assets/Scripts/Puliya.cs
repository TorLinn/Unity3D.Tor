using UnityEngine;
using System.Collections;

public class Puliya : MonoBehaviour {
	Vector3 start, potoch;

	// Use this for initialization
	void Start () {
		start = gameObject.transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
		potoch = gameObject.transform.position;
		if ((Mathf.Abs(start.x - potoch.x) > 1.05f) || (Mathf.Abs(start.y - potoch.y) > 1.05f)){
			Destroy(gameObject);
		}
		
	}
}
