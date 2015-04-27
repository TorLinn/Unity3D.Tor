using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Ruh : MonoBehaviour
{

	private static Ruh _pat;
	public static Ruh pat {
		get {
			if (_pat == null) {
				_pat = GameObject.FindObjectOfType<Ruh> ();
				DontDestroyOnLoad (_pat.gameObject);
			}
			return _pat;
		}
	}
	void Awake ()
	{
		if (_pat == null) {
			_pat = this;
			DontDestroyOnLoad (_pat.gameObject);
		} else if (this != _pat) {
			Destroy (this.gameObject);
		}
	} 

	public int Gold = 0;
	public int HP = 100;
	public Transform sens;
	public LayerMask laypov;
	public GameObject pula;
	bool zeml = false;
	Animator anim;
	Rigidbody2D rB;
	bool rkot = true;
	float timer = 0;
	float ruh = 0;
	float ruhp = 1;
	Vector3 kam;

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.name == "pulya(Clone)") {
			Destroy (col.gameObject);
			HP = HP - 30;
			if (HP < 0) {
				Color color = GetComponent<SpriteRenderer> ().color;
				color.a = 0.3f;
				GetComponent<SpriteRenderer> ().color = color;
			}
		}
	}
	void Ataka ()
	{

		GameObject obj = (GameObject)Instantiate (pula, gameObject.transform.position, Quaternion.identity);
		obj.GetComponent<Rigidbody2D> ().velocity = new Vector2 (10 * ruhp, 0);
	}
	
	// Use this for initialization
	void Start ()
	{
		kam = Camera.main.transform.position - gameObject.transform.position;
		anim = gameObject.GetComponent<Animator> ();
		rB = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update ()
	{

		Camera.main.transform.position = gameObject.transform.position + kam;

		if (zeml && Input.GetKeyDown (KeyCode.Space)) {
			anim.SetBool ("Grunt", false);
			rB.velocity = new Vector2 (rB.velocity.x, 9f);
		}
		if (Input.GetKeyDown (KeyCode.Q)) {
			Ataka ();
		}
		if (gameObject.transform.position.y < -3) {
			gameObject.transform.position = new Vector3 (0, 0, 0);
		}
	}

	void FixedUpdate ()
	{
		zeml = Physics2D.OverlapCircle (sens.position, 0.4f, laypov);
		anim.SetBool ("Grunt", zeml);
		anim.SetFloat ("YSpeed", rB.velocity.y);

		ruh = Input.GetAxis ("Horizontal");
		anim.SetFloat ("XSpeed", Mathf.Abs (ruh));
		rB.velocity = new Vector2 (10 * ruh, rB.velocity.y);

		if (ruh > 0 && !rkot) {
			rkot = !rkot;
			Vector3 rozmir = transform.localScale;
			rozmir.x *= -1;
			transform.localScale = rozmir;
			ruhp = 1;
		} else if (ruh < 0 && rkot) {
			rkot = !rkot;
			Vector3 rozmir = transform.localScale;
			rozmir.x *= -1;
			transform.localScale = rozmir;
			ruhp = -1;
		}
	}
}
