using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TxtHP : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.name == "HP") {
			gameObject.GetComponent<Text>().text = "HP = " + GameObject.Find("Sphere").GetComponent<dvig>().HP;
		}
		if (gameObject.name == "Velosity") {
			gameObject.GetComponent<Text>().text = "Priskor = " + GameObject.Find("Sphere").GetComponent<dvig>().priskor;
		}
		if (gameObject.name == "Stan") {
			gameObject.GetComponent<Text>().text = "Stan = " + GameObject.Find("Sphere").GetComponent<dvig>().mystan;
		}
	}
}
