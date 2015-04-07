using UnityEngine;
using System.Collections;

public class Parallax : MonoBehaviour {
	public Transform [] tmas;
	float ruh, ruhV, tmp, razn;

	// Use this for initialization
	void Start () {
		ruhV = gameObject.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		tmas [0].localPosition -= new Vector3 (0.01f,0,0); 
		tmas [1].localPosition -= new Vector3 (0.01f,0,0); 
		for (int i = 0; i < 2; i++) {
			if (tmas [i].localPosition.x < -30) {
				tmas [i].localPosition += new Vector3 (60, 0, 0);
			}
			if (tmas [i].localPosition.x > 30) {
				tmas [i].localPosition -= new Vector3 (60, 0, 0);
			}
		}
		ruh = Input.GetAxis ("Horizontal");
		if (Mathf.Abs(ruh)>0.1) {
			tmas [0].localPosition -= new Vector3 (0.01f*ruh,0,0); 
			tmas [1].localPosition -= new Vector3 (0.01f*ruh,0,0); 
			tmas [2].localPosition -= new Vector3 (0.02f*ruh,0,0); 
			tmas [3].localPosition -= new Vector3 (0.02f*ruh,0,0); 
			tmas [4].localPosition -= new Vector3 (0.03f*ruh,0,0); 
			tmas [5].localPosition -= new Vector3 (0.03f*ruh,0,0);
			for (int i = 0; i < 6; i++) {
				if (tmas[i].localPosition.x<-30) {
					tmas [i].localPosition += new Vector3 (60, 0, 0);
				}
				if (tmas[i].localPosition.x>30) {
					tmas [i].localPosition -= new Vector3 (60, 0, 0);
				}
			}
		}
		tmp = gameObject.transform.position.y;
		razn = ruhV - tmp;
		if (Mathf.Abs(razn)>0.01) {
			for (int i = 0; i < 6; i++) {
				tmas [i].localPosition += new Vector3 (0,0.1f*razn,0); 
			}
		}
		ruhV = gameObject.transform.position.y;
	}
}
