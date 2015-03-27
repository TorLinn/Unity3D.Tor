using UnityEngine;
using System.Collections;

public class Player1 : MonoBehaviour {

	public GameObject obj;
	GameObject puliya;
	Rigidbody2D person;
	Vector2 napr = new Vector2 (1, 0);
	public int HP = 100;
	public int POint = 0;

	// Use this for initialization
	void Start () {
		person = GetComponent<Rigidbody2D> ();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetAxis ("Horizontal") > 0) {
			napr = new Vector2 (1,0);
		}
		else if (Input.GetAxis ("Horizontal") < 0) {
			napr = new Vector2 (-1,0);
		}
		else if (Input.GetAxis ("Vertical") > 0) {
			napr = new Vector2 (0,1);
		}
		else if (Input.GetAxis ("Vertical") < 0) {
			napr = new Vector2 (0,-1);
		}
		if ((Mathf.Abs (Input.GetAxis ("Horizontal")) > 0) || (Mathf.Abs (Input.GetAxis ("Vertical")) > 0)){
			person.velocity = new Vector2 (Input.GetAxis ("Horizontal") * 3, Input.GetAxis ("Vertical") * 3);
		}
		if (Input.GetKeyDown(KeyCode.Space)) {
			Vector3 trasa = gameObject.transform.position;
			puliya = (GameObject) Instantiate (obj, trasa, new Quaternion (0f, 0f, 0f, 0f));
			puliya.GetComponent<Rigidbody2D>().velocity = napr*2;
		}
	}
}
