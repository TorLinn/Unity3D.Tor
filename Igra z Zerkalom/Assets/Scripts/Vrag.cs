using UnityEngine;
using System.Collections;

public class Vrag : MonoBehaviour {
	Rigidbody2D person;
	int napr;

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Bullets") {
			Destroy(gameObject);
		}
		napr = Random.Range (1, 5);
		person.velocity = new Vector2 (Random.Range(-1,2), Random.Range(-1,2));
	}
	void OnCollisionEnter2D (Collision2D col)
	{
		person.velocity = new Vector2 (Random.Range(-1,2), Random.Range(-1,2));

	}


	// Use this for initialization
	void Start () {
		person = GetComponent<Rigidbody2D> ();
		person.velocity = new Vector2 (-1, 0);
		//napr = Random.Range (-1, 2);
	}
	
	// Update is called once per frame
	void Update () {

	
	}
}
