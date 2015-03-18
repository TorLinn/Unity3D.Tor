using UnityEngine;
using System.Collections;

public class Naoborot : MonoBehaviour {

	int chislo, tmp, oborot = 0, j = 1;


	// Use this for initialization
	void Start () {
		chislo = Random.Range (1,10000);
		print ("do = "+chislo);
		for (int i = 1000; i >= 1; i = i/10) {
			tmp = chislo / i;
			chislo = chislo - tmp*i;
			oborot = oborot + tmp*j;
			j = j*10;
		}
		print ("posle = "+oborot);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
