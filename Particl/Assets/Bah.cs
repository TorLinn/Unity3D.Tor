using UnityEngine;
using System.Collections;

public class Bah : MonoBehaviour {

	float radius = 50.0f;
	float power = 0.2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnParticleCollision (GameObject col) {
		Vector3 explosionPos = transform.position;
		col.GetComponent<Rigidbody>().AddExplosionForce(power, explosionPos, radius, 0, ForceMode.Impulse);
	}
}
