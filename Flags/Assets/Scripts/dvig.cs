using UnityEngine;
using System.Collections;

public class dvig : MonoBehaviour
{
	public GameObject spel1, spel2, spel3;
	public float priskor = 10;
	public float HP = 100;

	[System.Flags]
	public enum Stan
	{            
		Stan1=1,
		Stan2=2, 
		Stan3=4
	} 

	public Stan mystan;

	void OnTriggerEnter (Collider col)
	{
		if (col.name == "Zona Damag") {
			mystan = mystan | Stan.Stan1;
		}
		if (col.name == "Zona Zdorov") {
			mystan = mystan | Stan.Stan2;
		}
		if (col.name == "Zona Medl") {
			mystan = mystan | Stan.Stan3;
		}
	}
	void OnTriggerExit (Collider col)
	{
		if (col.name == "Zona Damag") {
			mystan &= ~ Stan.Stan1;
		}
		if (col.name == "Zona Zdorov") {
			mystan &= ~ Stan.Stan2;
		}
		if (col.name == "Zona Medl") {
			mystan &= ~ Stan.Stan3;
		}
	}

	// Use this for initialization
	void Start ()
	{
			
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (Input.GetAxis ("Horizontal") * priskor, 0, Input.GetAxis ("Vertical") * priskor);
		if ((mystan & Stan.Stan1) == Stan.Stan1) {
			spel1.SetActive (true);
			HP -= 1;
		} else {
			spel1.SetActive (false);
		}
		if ((mystan & Stan.Stan2) == Stan.Stan2) {
			spel2.SetActive (true);
			HP += 1;
		} else {
			spel2.SetActive (false);
		}
		if ((mystan & Stan.Stan3) == Stan.Stan3) {
			spel3.SetActive (true);
			priskor = 1;
		} else {
			spel3.SetActive (false);
			priskor = 10;
		}
	}
}
