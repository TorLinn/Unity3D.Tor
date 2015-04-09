using UnityEngine;
using System.Collections;

public class Box : MonoBehaviour {

	void OnTriggerStay (Collider col) {
		
		print ("!");
		//Destroy(gameObject);
		//col.transform.GetComponent<Player>().Score +=1;
		
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
