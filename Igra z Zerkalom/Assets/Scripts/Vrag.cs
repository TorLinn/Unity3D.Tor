using UnityEngine;
using System.Collections;

public class Vrag : MonoBehaviour {
	Rigidbody2D person;
	int[] napr = {0,1,2,3};
	int naprav = 0;
	public LayerMask pol;

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Bullets") {
			Destroy(gameObject);
		}

		//person.velocity = new Vector2 (Random.Range(-1,2), Random.Range(-1,2));
	}
	void OnCollisionEnter2D (Collision2D col)
	{
		//person.velocity = new Vector2 (Random.Range(-1,2), Random.Range(-1,2));

	}


	// Use this for initialization
	void Start () {
		person = GetComponent<Rigidbody2D> ();
		person.velocity = new Vector2 (-1, 0);
		//nap = Random.Range (-1, 2);






	}
	
	// Update is called once per frame
	void Update () {
		Vector2 [] kola = new Vector2[4];
		kola [0] = new Vector2 (transform.position.x-0.5f, transform.position.y);
		kola [1] = new Vector2 (transform.position.x, transform.position.y+0.5f);
		kola [2] = new Vector2 (transform.position.x+0.5f, transform.position.y);
		kola [3] = new Vector2 (transform.position.x, transform.position.y-0.5f);
		for (int i = 0; i < 4; i++) {
			if (Physics2D.OverlapCircle (kola[i], 0.1f, pol) == false) {
				if (i == 0) {
					person.velocity = new Vector2 (-1, 0);
				}
				if (i == 1) {
					person.velocity = new Vector2 (0, 1);
				}
				if (i == 2) {
					person.velocity = new Vector2 (1, 0);
				}
				if (i == 3) {
					person.velocity = new Vector2 (0, -1);
				}
			}
		}

	
	}
}
