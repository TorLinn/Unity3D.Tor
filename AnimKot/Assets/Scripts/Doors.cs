using UnityEngine;
using System.Collections;

public class Doors : MonoBehaviour {
	Animator anim;
	void OnTriggerStay2D (Collider2D col){
		anim.SetBool ("Dveri", true);
		if ((col.name == "Kot") && (Input.GetKeyDown(KeyCode.Return))) {
			print ("!!");
			if (gameObject.name == "door 1") {
				print("Level 1");
				Application.LoadLevel(1);
			}
			if (gameObject.name == "door 2") {
				print("Level 2");
				Application.LoadLevel(2);
			}
			if (gameObject.name == "door 3") {
				print("Level 3");
				Application.LoadLevel(3);
			}
			if (gameObject.name == "door") {
				print("Level 0");
				Application.LoadLevel(0);
			}
		}
	}
	void OnTriggerExit2D (Collider2D col){
		anim.SetBool ("Dveri", false);
	}

	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
