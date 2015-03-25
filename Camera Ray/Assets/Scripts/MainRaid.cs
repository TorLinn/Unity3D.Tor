using UnityEngine;
using System.Collections;

public class MainRaid : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray luch = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (luch, out hit, 100f)) {
				print (hit.distance);
				hit.collider.GetComponent<Raiden> ().Coll = new Color (Random.Range (0, 1f), Random.Range (0, 1f), Random.Range (0, 1f));
			}
		}

	}
}
