using UnityEngine;
using System.Collections;

public class Puliya : MonoBehaviour {
	Vector3 start, potoch;

	void OnTriggerEnter2D (Collider2D col)
	{
		Destroy(gameObject);
	}

	// Use this for initialization
	void Start () {
		start = gameObject.transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
		potoch = gameObject.transform.position;
		if ((Mathf.Abs(start.x - potoch.x) > 0.95f) || (Mathf.Abs(start.y - potoch.y) > 0.95f)){
			Destroy(gameObject);
		}
		
	}
}
