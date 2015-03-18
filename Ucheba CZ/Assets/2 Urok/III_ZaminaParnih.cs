using UnityEngine;
using System.Collections;

public class III_ZaminaParnih : MonoBehaviour {
	public int n;
	// Use this for initialization
	void Start () {
		string s = "";
		int[] mas = new int[n];
		for (int i = 0; i < n; i++) {
			mas[i] = Random.Range(1,10);
			if (mas[i]%2 != 0) {
				mas[i] = 0;
			}
			s = s + mas[i] + " ";
		}
		print (s);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
