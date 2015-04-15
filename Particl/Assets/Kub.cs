using UnityEngine;
using System.Collections;

public class Kub : MonoBehaviour {
	public GameObject txt;
	public int HP = 12;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		txt.GetComponent<TextMesh>().text = HP.ToString();

	}
	void OnParticleCollision (GameObject col) {
		if (col.name == "Bomba") {
			HP -= 3;
		}
		if (col.name == "Kaseta") {
			HP -= 1;
		}
	}
}
