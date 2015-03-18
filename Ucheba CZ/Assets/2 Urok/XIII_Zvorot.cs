using UnityEngine;
using System.Collections;

public class XIII_Zvorot : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string s = "Написати рядок в зворотному порядку";
		string z = "";
		for (int i = 0; i < s.Length; i++) {
			z = z+s[s.Length-i-1];
		}
		print (z);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
