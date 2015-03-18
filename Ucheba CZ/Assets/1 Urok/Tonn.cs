using UnityEngine;
using System.Collections;

public class Tonn : MonoBehaviour {
	public int mass;
	int tonn;

	// Use this for initialization
	void Start () {
		tonn = mass / 1000;
		print (tonn);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
