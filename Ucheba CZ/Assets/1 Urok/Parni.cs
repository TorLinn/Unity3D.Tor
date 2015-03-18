using UnityEngine;
using System.Collections;

public class Parni : MonoBehaviour {
	int test, count, parni = 0;

	// Use this for initialization
	void Start () {
		count = Random.Range (4,10);
		print ("count = "+count);
		for (int i = 0; i < count; i++) {
			test = Random.Range (1,11);
			print ("test = "+test);
			if (test % 2 == 0) {
				parni++;
			}
		}
		print ("parni = "+parni);
		}
	
	// Update is called once per frame
	void Update () {
	
	}
}
