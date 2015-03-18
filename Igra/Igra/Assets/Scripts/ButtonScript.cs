using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {

	int x,y, count;
	string nnam;

	void OnMouseDown () {
		print (gameObject.name);
		//GetComponent<SpriteRenderer> ().color = Color.clear;
		count = 0;
		if ((y - 1 >= 0) && (GetComponent<SpriteRenderer> ().color == Main_Script.kollMas [x, y - 1].GetComponent<SpriteRenderer> ().color)) {
			Main_Script.kollMas [x, y - 1].GetComponent<SpriteRenderer> ().color = Color.clear;
			count = 1;
		}
		if ((y + 1 <= 24) && (GetComponent<SpriteRenderer> ().color == Main_Script.kollMas [x, y + 1].GetComponent<SpriteRenderer> ().color)) {
			Main_Script.kollMas [x, y + 1].GetComponent<SpriteRenderer> ().color = Color.clear;
			count = 1;
		}
		if ((x - 1 >= 0) && (GetComponent<SpriteRenderer> ().color == Main_Script.kollMas [x - 1, y].GetComponent<SpriteRenderer> ().color)) {
			Main_Script.kollMas [x - 1 , y].GetComponent<SpriteRenderer> ().color = Color.clear;
			count = 1;
		}
		if ((x + 1 <= 14) && (GetComponent<SpriteRenderer> ().color == Main_Script.kollMas [x + 1, y].GetComponent<SpriteRenderer> ().color)) {
			Main_Script.kollMas [x + 1, y].GetComponent<SpriteRenderer> ().color = Color.clear;
			count = 1;
		}

		if (count != 0) {
			GetComponent<SpriteRenderer> ().color = Color.clear;
		}


		//сортування писля кліка


	}



		/*for (int i = x-1; i <= x+1; i++) {
			for (int j = y-1; j <= y+1; j++) {
				if ((i >= 0 && i < 15) && (j >= 0 && j < 25)) {
					if (GetComponent<SpriteRenderer> ().color == Main_Script.kollMas[i, j].GetComponent<SpriteRenderer> ().color) {
						GetComponent<SpriteRenderer> ().color = Color.clear;
						Main_Script.kollMas[i, j].GetComponent<SpriteRenderer> ().color = Color.clear;
					}
				}
			}
		}*/




	// Use this for initialization
	void Start () {
		nnam = gameObject.name;
		x = int.Parse (nnam.Substring (2, 2));
		y = int.Parse (nnam.Substring (5, 2));
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
