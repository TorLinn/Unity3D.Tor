using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

	float ruh;
	Rigidbody rb;
	public int Bali = 0;
	bool paus = false;

	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!paus) {
			ruh = Input.GetAxis ("Horizontal");
			rb.velocity = new Vector3 (Input.GetAxis ("Horizontal") * 10, 0, Input.GetAxis ("Vertical") * 10);	
		}
		if (Bali >= 8) {
			paus = true;
			rb.velocity = new Vector3 (0, 0, 0);
			Application.LoadLevel (1);
		}
	}
}
