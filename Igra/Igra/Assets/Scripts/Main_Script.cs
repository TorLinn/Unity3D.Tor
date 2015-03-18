using UnityEngine;
using System.Collections;

public class Main_Script : MonoBehaviour {

	// Основні змінні
	public static int razmX = 9;
	public static int razmY = 9;
	public GameObject kolll;
	public static GameObject [,] kollMas = new GameObject[razmX, razmY];
	Color[] cVet = {Color.red, Color.gray, Color.green, Color.blue, Color.yellow};

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 9; i++) {
			for (int j = 0; j < 9; j++) {
				int d = Random.Range(0, 5);
				kollMas[i,j] = (GameObject)Instantiate (kolll, new Vector3 (0+i, 0+j, 0), new Quaternion (0f, 0f, 0f, 0f));
				kollMas[i,j].GetComponent<SpriteRenderer> ().color = cVet[d];
				kollMas [i,j].name = string.Format ("c_{0:00}_{1:00}", i, j);


			}
		}
	}
	
	// Update is called once per frame
	void Update () {


	}
}
