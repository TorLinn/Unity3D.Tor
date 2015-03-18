using UnityEngine;
using System.Collections;

public class MaxMin : MonoBehaviour {
	public int a, b, c;
	int min, max;

	// Use this for initialization
	void Start () {
		min = a;
		if (min > b) {
			min = b;
		}
		if (min > c) {
			min = c;
		}
		max = a;
		if (max < b) {
			max = b;
		}
		if (max < c) {
			max = c;
		}
		print ("min="+min+" max="+max);
	}


	// Update is called once per frame
	void Update () {
	
	}
}
