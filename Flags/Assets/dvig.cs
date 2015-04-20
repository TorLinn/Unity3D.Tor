using UnityEngine;
using System.Collections;

public class dvig : MonoBehaviour {

	public float priskor = 10;
	public float HP = 100;

	[System.Flags]
	public enum Stan
	{            
		Stan1=1<<0,		//    1 = 0001
		Stan2=1<<1,        //    2 = 0010
		Stan3=1<<2			//    4 = 0100
	} 

	public Stan mystan;

	void OnTriggerEnter (Collider col) {
		if (col.name == "Zona Damag") {
			mystan = mystan | Stan.Stan1;
			print (mystan);
		}
		if (col.name == "Zona Zdorov") {
			mystan = mystan | Stan.Stan2;
			print (mystan);
		}
		if (col.name == "Zona Medl") {
			mystan = mystan | Stan.Stan3;
			print (mystan);
		}
	}
	void OnTriggerExit (Collider col) {
		if (col.name == "Zona Damag") {
			mystan &=~ Stan.Stan1;
			print (mystan);
		}
		if (col.name == "Zona Zdorov") {
			mystan &=~ Stan.Stan2;
			print (mystan);
		}
		if (col.name == "Zona Medl") {
			mystan &=~ Stan.Stan3;
			print (mystan);
		}
	}

	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		gameObject.GetComponent<Rigidbody>().velocity = new Vector3 (Input.GetAxis ("Horizontal")*priskor, 0, Input.GetAxis ("Vertical")*priskor);
		if ((mystan & Stan.Stan1)==Stan.Stan1) {
			HP -= 1;
		}
		if ((mystan & Stan.Stan2)==Stan.Stan2) {
			HP += 1;
		}
		if ((mystan & Stan.Stan3)==Stan.Stan3) {
			priskor = 1;
		}
		else {
			priskor = 10;
		}
	}
}
