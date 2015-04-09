using UnityEngine;
using System.Collections;

public class Monstr : MonoBehaviour {

	public GameObject Monst;
	GameObject obj;

	void OnTriggerEnter (Collider col) {
		if (col.tag == "Player") {
			Destroy(gameObject);
			col.transform.GetComponent<Play>().HP -=30;
			obj = (GameObject) Instantiate (Monst, new Vector3 (45,0,45), Quaternion.identity);
			obj.GetComponent<NavMeshAgent>().enabled = true;
			obj.GetComponent<Monstr>().enabled = true;
		}
	}

	public GameObject person;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<NavMeshAgent> ().SetDestination (person.transform.position);

	}
}
