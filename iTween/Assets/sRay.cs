using UnityEngine;
using System.Collections;

public class sRay : MonoBehaviour {
	
	public GameObject sfera, parr;
	GameObject obj;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray luch = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (luch, out hit, 100f)) {
				for (int i = 0; i < 4; i++) {
					obj = (GameObject) Instantiate (sfera, hit.collider.transform.position, new Quaternion (0,0,0,0));
					obj.transform.parent = hit.collider.transform;
				}
			}
		}
	}
}
