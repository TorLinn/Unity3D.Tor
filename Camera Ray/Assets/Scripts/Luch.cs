using UnityEngine;
using System.Collections;

public class Luch : MonoBehaviour {
	public GameObject obj;
	GameObject obGs;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray luch = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (luch, out hit, 100f)) {
				Vector3 objPoss = hit.point + new Vector3 (hit.normal.x/2f, hit.normal.y/2f, hit.normal.z/2f);
				obGs = (GameObject) Instantiate (obj, objPoss, new Quaternion (0f, 0f, 0f, 0f));
			}
		}
	
	}
}
