using UnityEngine;
using System.Collections;

public class Targeti : MonoBehaviour {
	public GameObject targets;
	GameObject obj;
	public int Kilk = 5;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < Kilk; i++) {
			obj = (GameObject) Instantiate (targets, new Vector3 (Random.Range (50,350), 200, Random.Range (50,350)), Quaternion.identity);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
