using UnityEngine;
using System.Collections;

public class Raiden : MonoBehaviour {
	public Color Coll;

	// Use this for initialization
	void Start () {
		Coll = transform.GetComponent<MeshRenderer> ().material.color;
	}
	
	// Update is called once per frame
	void Update () {
		transform.GetComponent<MeshRenderer> ().material.color = Color.Lerp (transform.GetComponent<MeshRenderer> ().material.color, Coll, 0.1f);;
	}
}
