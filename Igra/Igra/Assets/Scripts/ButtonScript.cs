using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ButtonScript : MonoBehaviour {

	int x,y;
	string nnam;

	private void poisk (int f, int z, Color colLor) {
		Color tempC = colLor;
			if ((z - 1 >= 0) && (tempC == Main_Script.kollMas [f, z - 1].GetComponent<SpriteRenderer> ().color)) {
				Main_Script.kollMas [f, z - 1].GetComponent<SpriteRenderer> ().color = Color.clear;
				Main_Script.kollMas [f , z].GetComponent<SpriteRenderer> ().color = Color.clear;
				poisk (f,z-1,tempC);
			}
			if ((z + 1 <= 24) && (tempC == Main_Script.kollMas [f, z + 1].GetComponent<SpriteRenderer> ().color)) {
				Main_Script.kollMas [f,z+1].GetComponent<SpriteRenderer> ().color = Color.clear;
				Main_Script.kollMas [f , z].GetComponent<SpriteRenderer> ().color = Color.clear;
				poisk (f,z+1,tempC);
			}
			if ((f - 1 >= 0) && (tempC == Main_Script.kollMas [f - 1, z].GetComponent<SpriteRenderer> ().color)) {
				Main_Script.kollMas [f - 1, z].GetComponent<SpriteRenderer> ().color = Color.clear;
				Main_Script.kollMas [f , z].GetComponent<SpriteRenderer> ().color = Color.clear;
				poisk (f-1,z,tempC);
			}
			if ((f + 1 <= 14) && (tempC == Main_Script.kollMas [f + 1, z].GetComponent<SpriteRenderer> ().color)) {
			Main_Script.kollMas [f + 1, z].GetComponent<SpriteRenderer> ().color = Color.clear;
			Main_Script.kollMas [f, z].GetComponent<SpriteRenderer> ().color = Color.clear;
			poisk (f + 1, z, tempC);
		}
	}	

	void OnMouseDown () {
		print (gameObject.name);
		if (GetComponent<SpriteRenderer> ().color != Color.clear) {
			poisk (x,y, Main_Script.kollMas [x , y].GetComponent<SpriteRenderer> ().color);
		}

		//сортування писля кліка
		for (int i = 0; i < 15; i++) {
			//sort col
			int k1 = 0;
			int k2 = 24;
			Color[] tmpColors = new Color[25];
			for (int j = 0; j < 25; j++) {
				if (Main_Script.kollMas [i, j].GetComponent<SpriteRenderer> ().color == (Color.clear)) {
					tmpColors [k2] = Color.clear;
					k2--;
				} else {
					tmpColors [k1] = Main_Script.kollMas [i, j].GetComponent<SpriteRenderer> ().color;
					k1++;
				}
			}
			for (int j = 0; j < 25; j++) {
				Main_Script.kollMas [i, j].GetComponent<SpriteRenderer> ().color = tmpColors [j];
			}
		}


		//сортування писля кліка

		/*for (int p = 0; p < 25; p++) {
			for (int i = 0; i < 15; i++) {
				for (int j = 0; j < 24; j++) {
					for (int o = j+1; o < 25; o++) {
						if (Main_Script.kollMas [i, j].GetComponent<SpriteRenderer> ().color == Color.clear) {
							Color temp = Main_Script.kollMas [i, j].GetComponent<SpriteRenderer> ().color;
							Main_Script.kollMas [i, j].GetComponent<SpriteRenderer> ().color = Main_Script.kollMas [i, o].GetComponent<SpriteRenderer> ().color;
							Main_Script.kollMas [i, o].GetComponent<SpriteRenderer> ().color = temp;
						}
					}
				}
			}
		}*/
	}

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
