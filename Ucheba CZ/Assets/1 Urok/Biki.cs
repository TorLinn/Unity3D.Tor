using UnityEngine;
using System.Collections;

public class Biki : MonoBehaviour {
	float cena, biki = 10, korovi = 5, telki = 0.5f, bablo = 100;
	int count, golovi = 100;
	// Use this for initialization
	void Start () {
		for (int i = 0; i <= 100/biki; i++) {
			for (int j = 0; j <= 100/korovi; j++) {
				for (int l = 0; l <= 100/telki; l++) {
					count = i+j+l;
					cena = i*biki+j*korovi+l*telki;
					if (count == 100 && cena == 100) {
						print ("biki = "+i+"; korovi = "+j+"; telki = "+l);
					}
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
