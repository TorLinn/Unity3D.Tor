using UnityEngine;
using System.Collections;

public class VIII_MinusivMass : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string s;
		int dlina = Random.Range (5,10);
		int[] mas1 = new int[dlina], mas2 = new int[dlina];

		//создание первоначального массива
		s = "";
		for (int i = 0; i < dlina; i++) {
			mas1[i] = Random.Range(-9,10);
			s = s + mas1[i]+" ";
		}
		print ("одновимірний масив : \n "+s);

		//создание массива начинающегося с отрицательных значений

		int count = 0, ni = 0, pi = 1;
		for (int j = 0; j < dlina; j++) {
			if (mas1[j]<0) {
				mas2[ni] = mas1[j];
				ni = ni+1;
			}
			if (mas1[j] >= 0) {
				mas2[dlina-pi] = mas1[j];
				pi = pi+1;
			}
		}
		s = "";
		for (int i = 0; i < dlina; i++) {
			s = s + mas2[i]+" ";
		}
		print ("одновимірний масив : \n "+s);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
