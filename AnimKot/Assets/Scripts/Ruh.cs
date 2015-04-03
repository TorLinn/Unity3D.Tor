using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Ruh : MonoBehaviour {

	public int Gold = 0;
	public Transform sens;
	public LayerMask laypov;
	bool zeml = false;
	Animator anim;
	Rigidbody2D rB;
	bool rkot = true;

	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator> ();
		rB = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (zeml && Input.GetKeyDown(KeyCode.Space)) {
			anim.SetBool("Grunt",false);
			rB.velocity = new Vector2(rB.velocity.x, 9f);
		}
		if (gameObject.transform.position.y < -3) {
			gameObject.transform.position = new Vector3 (0,0,0);
		}
	}

	void FixedUpdate () {
		zeml = Physics2D.OverlapCircle (sens.position, 0.4f, laypov);
		anim.SetBool ("Grunt", zeml);
		anim.SetFloat ("YSpeed", rB.velocity.y);

		float ruh = Input.GetAxis ("Horizontal");
		anim.SetFloat ("XSpeed", Mathf.Abs(ruh));
		rB.velocity = new Vector2 (10*ruh, rB.velocity.y);

		if (ruh > 0 && !rkot) {
			rkot = !rkot;
			Vector3 rozmir = transform.localScale;
			rozmir.x *= -1;
			transform.localScale = rozmir;
		} 
		else if (ruh < 0 && rkot) {
			rkot = !rkot;
			Vector3 rozmir = transform.localScale;
			rozmir.x *= -1;
			transform.localScale = rozmir;
		}
	}
}
