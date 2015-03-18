using UnityEngine;
using System.Collections;

public class XII_Simvoli : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string s = "Порахувати скільки різних символів в даному рядку";
		float count = 0;

		for (int i = 0; i < s.Length; i++) {
			if (s[i]!='@') {
				count = count+1;
				char ss = s[i];
				s = s.Replace(ss,'@');
			}
		}
		print (count);
		print (s);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
