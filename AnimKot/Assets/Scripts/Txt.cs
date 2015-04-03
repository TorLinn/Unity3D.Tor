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
		gameObject.GetComponent<Text> ().text = "Gold = " + obj.GetComponent<Ruh> ().Gold;

	
	}
}
