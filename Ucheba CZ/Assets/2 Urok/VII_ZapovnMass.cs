using UnityEngine;
using System.Collections;

public class VII_ZapovnMass : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int masrazm = Random.Range (6,10);
		int[,] mass = new int[masrazm,masrazm];
		string s;
		int count = 1;

		//заполнение массива с выделением диагоналей

		s = "";
		for (int i = 0; i < masrazm; i++) {
			for (int j = 0; j < masrazm; j++) {
				if ( i == j || j == masrazm - i - 1) {
					mass [i,j] = 1;
				}
				else {
					mass [i,j] = 0;
				}
				s = s + mass[i,j]+" ";
			}
			s = s + "\n";
		}
		print ("масcив с выделением диагоналей : \n"+s);

		//заполнение массива циклично

		s = "";
		for (int i = 0; i < masrazm; i++) {
			for (int j = 0; j < masrazm; j++) {
				if (count > masrazm) {
					count = count - masrazm;
				}
				mass [i,j] = count;
				count = count +1;
				s = s + mass[i,j]+" ";
			}
			count = count + 1;
			s = s + "\n";
		}
		print ("масcив с цикличным заполнением : \n"+s);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
