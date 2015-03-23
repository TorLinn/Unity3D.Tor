using UnityEngine;
using System.Collections;

public class MainScript : MonoBehaviour {

	public GameObject [] mMas = new GameObject[7];
	string s;
	GameObject obj;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		s += Input.inputString;
		print (s);
		for (int i = 0; i < mMas.Length; i++) {
			if (s == mMas[i].name) {
				print ("Bingo!!!");
				obj = (GameObject) Instantiate (mMas[i], new Vector3 (Random.Range(-6f,6f), Random.Range(-6f,6f), 0), new Quaternion (0f, 0f, 0f, 0f));
				s = "";
			}
		}
	
	}
}
