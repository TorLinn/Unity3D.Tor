using UnityEngine;
using System.Collections;

public class Trehznachni : MonoBehaviour {

	int test, count, parni = 0;
	
	// Use this for initialization
	void Start () {
		count = Random.Range (4,10);
		print ("count = "+count);
		for (int i = 0; i < count; i++) {
			test = Random.Range (1,200);
			print ("test = "+test);
			if (test - 100 >= 0 && test - 900 < 100) {
				parni++;
			}
		}
		print ("triznachni = "+parni);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
