using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Dvig4 : MonoBehaviour
{

	Input inp = new Input ();

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		gameObject.transform.FindChild ("Text").GetComponent<Text> ().text = inp.GetKeyDownD ("z", "x").ToString ();
		gameObject.transform.FindChild ("Text").GetComponent<Text> ().text = inp.GetKeyD ("z", "x").ToString ();
		//gameObject.transform.FindChild ("Text").GetComponent<Text> ().text = inp.GetKeyUpD ("z", "x").ToString ();

		gameObject.transform.FindChild ("Text1").GetComponent<Text> ().text = inp.GetKeyDownD (KeyCode.Q, KeyCode.W).ToString ();
		gameObject.transform.FindChild ("Text1").GetComponent<Text> ().text = inp.GetKeyD (KeyCode.Q, KeyCode.W).ToString ();
		//gameObject.transform.FindChild ("Text").GetComponent<Text> ().text = inp.GetKeyUpD (KeyCode.Q, KeyCode.W).ToString ();
	}
}
