using UnityEngine;
using System.Collections;

public class Vrag : MonoBehaviour {
	Rigidbody2D person;
	int naprav = 0;
	public LayerMask pol;
	Vector2 nachalo, potochno;
	float timer = 0;


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
		nachalo = transform.position;


	}
	
	// Update is called once per frame
	void Update () {
		potochno = transform.position;
		timer += Time.deltaTime;
		if ((Mathf.Abs(potochno.x - nachalo.x)>0.75f) || (Mathf.Abs(potochno.y - nachalo.y)>0.75f) || (timer>5)) {
			if (potochno.x-nachalo.x<0) {
				naprav = 0;
				//print(naprav);
			}
			if (potochno.y-nachalo.y>0) {
				naprav = 1;
				//print(naprav);
			}
			if (potochno.x-nachalo.x>0) {
				naprav = 2;
				//print(naprav);
			}
			if (potochno.y-nachalo.y<0) {
				naprav = 3;
				//print(naprav);
			}
			shag (person, naprav);
			nachalo = potochno;

		}



	
	}
	private void shag (Rigidbody2D pPerson, int nNaprav) {
		Vector2 [] kola = new Vector2[4];
		kola [0] = new Vector2 (transform.position.x-0.5f, transform.position.y);
		kola [1] = new Vector2 (transform.position.x, transform.position.y+0.5f);
		kola [2] = new Vector2 (transform.position.x+0.5f, transform.position.y);
		kola [3] = new Vector2 (transform.position.x, transform.position.y-0.5f);
		if ((Physics2D.OverlapCircle (kola [nNaprav], 0.2f, pol) == false)) {
			if ((nNaprav != 3) && ((Physics2D.OverlapCircle (kola [3], 0.2f, pol) == false)) && (Random.Range(0, 2) == 1)) {
				pPerson.velocity = new Vector2 (0, -1);
				print ("vniz");
				return;
			}
			if ((nNaprav != 0) && ((Physics2D.OverlapCircle (kola [0], 0.2f, pol) == false)) && (Random.Range(0, 2) == 1)) {
				pPerson.velocity = new Vector2 (-1, 0);
				print ("vlevo");
				return;
			}
			if ((nNaprav != 1) && ((Physics2D.OverlapCircle (kola [1], 0.2f, pol) == false)) && (Random.Range(0, 2) == 1)) {
				pPerson.velocity = new Vector2 (0, 1);
				print ("vverh");
				return;
			}
			if ((nNaprav != 2) && ((Physics2D.OverlapCircle (kola [2], 0.2f, pol) == false)) && (Random.Range(0, 2) == 1)) {
				pPerson.velocity = new Vector2 (1, 0);
				print ("vpravo");
				return;
			}
		} 
		else {
			print ("else");
		
			for (int i = 0; i < 4; i++) {

				if (Physics2D.OverlapCircle (kola [i], 0.2f, pol) == false) {
					if (i == 0) {
						pPerson.velocity = new Vector2 (-1, 0);
						print("livo");
						return;
					}
					if (i == 1) {
						pPerson.velocity = new Vector2 (0, 1);
						print ("vverh");
						return;
					}
					if (i == 2) {
						pPerson.velocity = new Vector2 (1, 0);
						print ("vpravo");
						return;
					}
					if (i == 3) {
						pPerson.velocity = new Vector2 (0, -1);
						print ("vniz");
						return;
					}
				}
			}
		}
	}
}
