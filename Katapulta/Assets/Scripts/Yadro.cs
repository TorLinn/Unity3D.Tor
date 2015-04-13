using UnityEngine;
using System.Collections;

public class Yadro : MonoBehaviour {
	public bool daged = false;
	public GameObject traek; //префаб траэктории
	float timer;
	GameObject obj;
	GameObject objJ;

	void OnCollisionEnter2D (Collision2D сol){
		daged = true;
	}

	// Use this for initialization
	void Start () {
		objJ = GameObject.Find("traektor");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		timer += Time.deltaTime; 

		//рисование траектории
		if (timer>0.1f) {
			if ((GetComponent<DistanceJoint2D>().enabled == false) && (transform.position.y>0.1f) && (!GetComponent<Yadro>().daged)) {
				obj = (GameObject) Instantiate (traek, transform.position, Quaternion.identity);
				obj.transform.parent = objJ.transform;
				timer = 0;
			}
		}
	}
}
