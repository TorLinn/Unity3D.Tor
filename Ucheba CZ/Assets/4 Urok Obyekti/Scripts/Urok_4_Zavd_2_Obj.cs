using UnityEngine;
using System.Collections;

public class Urok_4_Zavd_2_Obj : MonoBehaviour {

	int x,y;
	string nnam;
	public Sprite sprt;

	// Use this for initialization
	void Start () {

		nnam = gameObject.name;
		x = int.Parse (nnam.Substring (0, 1));
		y = int.Parse (nnam.Substring (2, 1));


	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseEnter () {
		for (int i = x-1; i < x+2; i++) {
			for (int j = y-1; j < y+2; j++) {
				if ((i >= 0 && i < 6) && (j >= 0 && j < 6)) {
					Urok_4_Zavd_2.kollMas[i, j].GetComponent<SpriteRenderer> ().color = Color.green;
				}
			}
		}
		GetComponent<SpriteRenderer> ().color = Color.red;
	}
	
	void OnMouseExit () {
		for (int i = 0; i < 6; i++) {
			for (int j = 0; j < 6; j++) {
				Urok_4_Zavd_2.kollMas[i, j].GetComponent<SpriteRenderer> ().color = Color.white;
			}
		}
	}
}
