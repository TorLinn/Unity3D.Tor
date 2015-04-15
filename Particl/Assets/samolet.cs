using UnityEngine;
using System.Collections;

public class samolet : MonoBehaviour {
	bool target = true;
	Vector3 cel;

	// Use this for initialization
	void Start () {
		Vector3 cel = new Vector3 (Random.Range(0f,100f), 50 , Random.Range(0f,100f));
	}
	
	// Update is called once per frame
	void Update () {
		Polet ();
		//iTween.MoveTo (gameObject, iTween.Hash());
		if (Vector3.Distance(transform.position, cel)<0.1f) {
			cel = new Vector3 (Random.Range(0f,100f), 50 , Random.Range(0f,100f));
		}
	}

	void Polet () {
		iTween.MoveTo (gameObject, iTween.Hash("x", cel.x,
		                                       "y", cel.y,
		                                       "z", cel.z,
		                                       "easetype", iTween.EaseType.easeOutCubic));
	}
}
