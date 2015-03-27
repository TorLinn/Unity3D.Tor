using UnityEngine;
using System.Collections;

public class HPtext : MonoBehaviour {
	public GameObject obj;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (obj.name == "pers1") {
			gameObject.GetComponent<TextMesh>().text = "HP1 = "+obj.GetComponent<Player1>().HP;
		}
		if (obj.name == "pers2") {
			gameObject.GetComponent<TextMesh>().text = "HP2 = "+obj.GetComponent<Player2>().HP;
		}


	}
}
