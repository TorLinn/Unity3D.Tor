using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Txt : MonoBehaviour {
	public GameObject obj;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.name == "Gold") {
			gameObject.GetComponent<Text> ().text = "Gold = " + Ruh.pat.Gold;
		}
		if (gameObject.name == "HP") {
			gameObject.GetComponent<Text> ().text = "HP = " + Ruh.pat.HP;
		}

	
	}
}
