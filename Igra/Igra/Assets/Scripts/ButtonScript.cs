using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {

	int x,y, count;
	string nnam;

	void OnMouseDown () {
		print (gameObject.name);
		//GetComponent<SpriteRenderer> ().color = Color.clear;
		count = 0;
		if (GetComponent<SpriteRenderer> ().color != Color.clear) {
			
		
			if ((y - 1 >= 0) && (GetComponent<SpriteRenderer> ().color == Main_Script.kollMas [x, y - 1].GetComponent<SpriteRenderer> ().color)) {
				//Destroy(Main_Script.kollMas [x, y - 1]);
				Main_Script.kollMas [x, y - 1].GetComponent<SpriteRenderer> ().color = Color.clear;

				//цикл для підйому пустих

				for (int i = y-1; i < 25; i++) {
					for (int j = i+1; j < 25; j++)
					{
						Color temp = Main_Script.kollMas[x, i].GetComponent<SpriteRenderer> ().color;
						Main_Script.kollMas[x, i].GetComponent<SpriteRenderer> ().color = Main_Script.kollMas[x, j].GetComponent<SpriteRenderer> ().color;
						Main_Script.kollMas[x, j].GetComponent<SpriteRenderer> ().color = temp;	
						
						//Main_Script.kollMas[x, j].GetComponent<SpriteRenderer> ().color=Main_Script.kollMas[i, j+1].GetComponent<SpriteRenderer> ().color;
						
					}
				}


				count = 1;
			}
			if ((y + 1 <= 24) && (GetComponent<SpriteRenderer> ().color == Main_Script.kollMas [x, y + 1].GetComponent<SpriteRenderer> ().color)) {
				//Destroy(Main_Script.kollMas [x, y + 1]);
				Main_Script.kollMas [x, y + 1].GetComponent<SpriteRenderer> ().color = Color.clear;

				//цикл для підйому пустих
					
				for (int i = y+1; i < 25; i++) {
					for (int j = i+1; j < 25; j++)
					{
						Color temp = Main_Script.kollMas[x, i].GetComponent<SpriteRenderer> ().color;
						Main_Script.kollMas[x, i].GetComponent<SpriteRenderer> ().color = Main_Script.kollMas[x, j].GetComponent<SpriteRenderer> ().color;
						Main_Script.kollMas[x, j].GetComponent<SpriteRenderer> ().color = temp;	
						
						//Main_Script.kollMas[x, j].GetComponent<SpriteRenderer> ().color=Main_Script.kollMas[i, j+1].GetComponent<SpriteRenderer> ().color;
						
					}
				}

				count = 1;
			}
			if ((x - 1 >= 0) && (GetComponent<SpriteRenderer> ().color == Main_Script.kollMas [x - 1, y].GetComponent<SpriteRenderer> ().color)) {
				//Destroy(Main_Script.kollMas [x - 1, y]);
				Main_Script.kollMas [x - 1, y].GetComponent<SpriteRenderer> ().color = Color.clear;

				//цикл для підйому пустих
				
				for (int i = y; i < 25; i++) {
					for (int j = i+1; j < 25; j++)
					{
						Color temp = Main_Script.kollMas[x-1, i].GetComponent<SpriteRenderer> ().color;
						Main_Script.kollMas[x-1, i].GetComponent<SpriteRenderer> ().color = Main_Script.kollMas[x-1, j].GetComponent<SpriteRenderer> ().color;
						Main_Script.kollMas[x-1, j].GetComponent<SpriteRenderer> ().color = temp;	
						
						//Main_Script.kollMas[x, j].GetComponent<SpriteRenderer> ().color=Main_Script.kollMas[i, j+1].GetComponent<SpriteRenderer> ().color;
						
					}
				}

				count = 1;
			}
			if ((x + 1 <= 14) && (GetComponent<SpriteRenderer> ().color == Main_Script.kollMas [x + 1, y].GetComponent<SpriteRenderer> ().color)) {
				//Destroy(Main_Script.kollMas [x + 1, y]);
				Main_Script.kollMas [x + 1, y].GetComponent<SpriteRenderer> ().color = Color.clear;

				//цикл для підйому пустих
				
				for (int i = y; i < 25; i++) {
					for (int j = i+1; j < 25; j++)
					{
						Color temp = Main_Script.kollMas[x+1, i].GetComponent<SpriteRenderer> ().color;
						Main_Script.kollMas[x+1, i].GetComponent<SpriteRenderer> ().color = Main_Script.kollMas[x+1, j].GetComponent<SpriteRenderer> ().color;
						Main_Script.kollMas[x+1, j].GetComponent<SpriteRenderer> ().color = temp;	
						
						//Main_Script.kollMas[x, j].GetComponent<SpriteRenderer> ().color=Main_Script.kollMas[i, j+1].GetComponent<SpriteRenderer> ().color;
						
					}
				}

				count = 1;
			}

			if (count != 0) {
				//Destroy(gameObject);
				GetComponent<SpriteRenderer> ().color = Color.clear;
				for (int i = y; i < 25; i++) {
					for (int j = i+1; j < 25; j++)
					{
						Color temp = Main_Script.kollMas[x, i].GetComponent<SpriteRenderer> ().color;
						Main_Script.kollMas[x, i].GetComponent<SpriteRenderer> ().color = Main_Script.kollMas[x, j].GetComponent<SpriteRenderer> ().color;
						Main_Script.kollMas[x, j].GetComponent<SpriteRenderer> ().color = temp;	

						//Main_Script.kollMas[x, j].GetComponent<SpriteRenderer> ().color=Main_Script.kollMas[i, j+1].GetComponent<SpriteRenderer> ().color;

					}
				}
			}
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
