using UnityEngine;
using System.Collections;

public class Urok_4_Zavd_2 : MonoBehaviour {

	public GameObject kolll;
	public static int razm = Random.Range(6,7);
	public static GameObject [,] kollMas = new GameObject[6,6];

	// Use this for initialization
	void Start () {
		for (int i = 0; i < razm; i++) {
			for (int j = 0; j < razm; j++) {
				kollMas [i,j] = (GameObject)Instantiate (kolll, new Vector3 (0+i*3, 0+j*3, 0), new Quaternion (0f, 0f, 0f, 0f));
				kollMas [i,j].transform.parent = transform;
				kollMas [i,j].name = i+"_"+j;
			}
		}
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}
}
