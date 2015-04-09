using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TargL : MonoBehaviour {

	public GameObject targ;
	GameObject obj;

	void OnTriggerEnter (Collider col) {
		if (col.tag == "Player") {
			Destroy(gameObject);
			col.transform.GetComponent<Player>().Score +=1;
			obj = (GameObject) Instantiate (targ, new Vector3 (Random.Range (50,350), 200, Random.Range (50,350)), Quaternion.identity);
			obj.GetComponent<Light>().enabled = true;
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y<50) {
			Destroy(gameObject);
			obj = (GameObject) Instantiate (targ, new Vector3 (Random.Range (50,350), 200, Random.Range (50,350)), Quaternion.identity);
			obj.GetComponent<Light>().enabled = true;
		}
	}
}
