using UnityEngine;
using System.Collections;

public class StepinN : MonoBehaviour {

	public float n, m;
	float summ = 0;

	// Use this for initialization
	void Start () {
		for (float i = 1; i <= m; i++) {
			summ = summ + Mathf.Pow(i,n);
		}	
		print (summ);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
