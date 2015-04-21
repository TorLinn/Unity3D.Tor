using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TxtHP : MonoBehaviour
{
	string St;

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.FindChild ("HP").GetComponent<Text> ().text = "HP = " + GameObject.Find ("Sphere").GetComponent<dvig> ().HP;
		transform.FindChild ("Velosity").GetComponent<Text> ().text = "Priskor = " + GameObject.Find ("Sphere").GetComponent<dvig> ().priskor;
		transform.FindChild ("Stan").GetComponent<Text> ().text = "Stan = " + GameObject.Find ("Sphere").GetComponent<dvig> ().mystan;
	}
}
