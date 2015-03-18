using UnityEngine;
using System.Collections;

public class X_Podvoennya : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string s = "В рядку знайти всі подвоєння та видалити символи так щоб не було подвоєн. Подвоєння, нння ппперрреїїххххаттии";
		string stemp = "";
		print (s);
		stemp = s.Remove (1);
		for (int i = 1; i < s.Length; i++) {
			if (s[i] != s [i-1]) {
				stemp = stemp + s[i];
			}
		}
		s = stemp;
		print (s);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
