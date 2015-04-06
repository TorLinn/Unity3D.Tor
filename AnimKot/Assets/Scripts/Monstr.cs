using UnityEngine;
using System.Collections;

public class Monstr : MonoBehaviour {

	public GameObject pulja, kot;
	public Transform disp, sensj, sensr, sensjp, sensord;
	public LayerMask lzemlja;
	bool bzemlja = false;
	bool rkot = true;
	Rigidbody2D rbody2d;
	Animator anim;
	float ruh, timer = 0;

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.name == "pul2") {
			Destroy (col.gameObject);
			gameObject.transform.position = new Vector3 (12,2,0);
			kot.GetComponent<Ruh>().Gold +=30;
		}
	}

	void Ataka ()
	{
		if (timer > 1) {
			GameObject obj = (GameObject)Instantiate (pulja, gameObject.transform.position, Quaternion.identity);
			print("!");
			obj.GetComponent<Rigidbody2D> ().velocity = new Vector2 (10 * ruh, 0);
			timer = 0;
		}
	}



	// Use this for initialization
	void Start () {
		rbody2d = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
		ruh = 1;

	}
	
	// Update is called once per frame
	void Update () {
		if (bzemlja && Physics2D.OverlapCircle (sensjp.position, 0.4f, lzemlja)) {
			anim.SetBool ("Grunt", false);
			rbody2d.velocity = new Vector2 (rbody2d.velocity.x, 8f);
		}
		if (gameObject.transform.position.y < -3) {
			gameObject.transform.position = new Vector3 (12,2,0);
		}
	
	}

	void FixedUpdate () {
		timer += Time.deltaTime;
		if (Mathf.Abs (disp.position.y - transform.position.y) < 0.1f) {
			if (disp.position.x - transform.position.x > 0) {
				ruh = 1; 
				Ataka ();
			} else {
				ruh = -1;
				Ataka ();
			}
		}

		bzemlja = Physics2D.OverlapCircle (sensj.position, 0.4f, lzemlja);
		anim.SetBool ("Grunt", bzemlja);
		anim.SetFloat ("YSpeed", rbody2d.velocity.y);
		if (!bzemlja) {
			return;
		}
		
		if (!Physics2D.OverlapCircle (sensr.position, 0.3f, lzemlja)  && !Physics2D.OverlapCircle (sensord.position, 0.3f, lzemlja)) {
			ruh *= -1;
		}
		
		anim.SetFloat ("XSpeed", Mathf.Abs (ruh));
		rbody2d.velocity = new Vector2 (ruh * 3, rbody2d.velocity.y);
		
		if (ruh > 0 && !rkot) {
			rkot = !rkot;
			Vector3 rozmir = transform.localScale;
			rozmir.x *= -1;
			transform.localScale = rozmir;
		} else if (ruh < 0 && rkot) {
			rkot = !rkot;
			Vector3 rozmir = transform.localScale;
			rozmir.x *= -1;
			transform.localScale = rozmir;
		}

	}
}
