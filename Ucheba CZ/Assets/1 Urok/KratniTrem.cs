using UnityEngine;
using System.Collections;

public class KratniTrem : MonoBehaviour {

	int test, count, parni = 0;
	
	// Use this for initialization
	void Start () {
		count = Random.Range (4,10);
		print ("count = "+count);
		for (int i = 0; i < count; i++) {
			test = Random.Range (1,11);
			print ("test = "+test);
			if (test % 3 == 0) {
				parni++;
			}
		}
		print ("kratni 3 = "+parni);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
