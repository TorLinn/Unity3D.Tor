using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
	float timer = 0;

	void OnTriggerEnter2D (Collider2D col)
	{	
		if (col.tag == "Monstr") {
			Destroy (gameObject);	
		}
	}
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		timer += Time.deltaTime;
		if (timer >= 5) {
			Destroy (gameObject);
		}
	
	}
}
