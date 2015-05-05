using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Txt : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (gameObject.name == "Bali") {
			gameObject.GetComponent<Text> ().text = "Bali = " + GameObject.Find ("Player").GetComponent<Player> ().Bali;
		}
	}
}
