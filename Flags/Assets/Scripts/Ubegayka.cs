using UnityEngine;
using System.Collections;

public class Ubegayka : MonoBehaviour
{
	public float speed = 1f;
	Vector3? dest = null;

	void OnCollisionEnter (Collision col)
	{	
		if (!dest.HasValue) {
			dest = new Vector3 (Random.Range (40f, 60f), 0f, Random.Range (40f, 70f));
		}
	}

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		if (dest.HasValue) {
			transform.position = Vector3.Lerp (transform.position, dest.Value, Time.deltaTime);
			if (Vector3.Distance (transform.position, dest.Value) < 1.5f) {
				dest = null;
			}
		}
	}
}
