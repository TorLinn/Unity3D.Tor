using UnityEngine;
using System.Collections;

public class VI_Zrostanya : MonoBehaviour {

	// Use this for initialization
	void Start () {

		// створення масиву
		string s;
		int dlina1 = Random.Range (1,10);

		//Одновимірний масив
		int[] mas1 = new int[dlina1]; 
		s = "";
		for (int i = 0; i < dlina1; i++) {
			mas1[i] = Random.Range(1,100);
			s = s + mas1[i]+" ";
		}	
		print ("початковий масив :  "+s);

		//сортування за зростанням
		for (int i = 0; i < dlina1-1; i++) {
			for (int j = i+1; j < dlina1; j++) {
				if (mas1[i]>mas1[j])
				{
					int tmp = mas1[i];
					mas1[i] = mas1[j];
					mas1[j] = tmp;
				}
			}
		}
		s = "";
		for (int i = 0; i < dlina1; i++) {
			s = s + mas1[i]+" ";
		}	
		print ("відсортований масив :  "+s);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
