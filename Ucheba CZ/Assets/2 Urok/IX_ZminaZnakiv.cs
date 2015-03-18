using UnityEngine;
using System.Collections;

public class IX_ZminaZnakiv : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string ss = "", s = "Дано рядок. Замінити в ньому всі входження ‘a’ на ‘@’ та ‘o’ на ‘*’.";
		for (int i = 0; i < s.Length; i++) {
			if (s[i] != 'а' && s[i] != 'о') {
				ss = ss + s[i];
			}
			else {
				if (s[i] == 'о') {
					ss = ss + '*';
				}
				if (s[i] == 'а') {
					ss = ss + '@';
				}
			}
		}
		print (ss);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
