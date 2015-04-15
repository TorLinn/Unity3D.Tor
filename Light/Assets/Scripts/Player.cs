using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	public int Score = 0;
	public Text canva, kr, sn;
	int kras = 0;
	int sin = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		canva.text = " Score = " + Score;
	}

	void OnParticleCollision (GameObject col) {
		if (col.name == "Sini") {
			sin += 1;
			sn.text = "Sini = " + sin;
		}
		if (col.name == "Krasni") {
			kras += 1;
			kr.text = "Krasni = " + kras;
		}
	}
}
