﻿using UnityEngine;
using System.Collections;

public class XPText : MonoBehaviour {
	public GameObject obj;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (obj.name == "pers1") {
			gameObject.GetComponent<TextMesh>().text = "XP1 = "+obj.GetComponent<Player1>().POint;
		}
		if (obj.name == "pers2") {
			gameObject.GetComponent<TextMesh>().text = "XP2 = "+obj.GetComponent<Player2>().POint;
		}
	
	}
}
