using UnityEngine;
using System.Collections;

public class ViborkaClick : MonoBehaviour {

	//ViborkaMain cls;
		
	void OnMouseDown (){
		print (gameObject.name);
		//print(transform.Find ("cilindr").transform.name);
		gameObject.GetComponent<SpriteRenderer> ().enabled = false;

	}

	// Use this for initialization
	void Start () {
		//cls = transform.GetComponent<ViborkaMain> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
