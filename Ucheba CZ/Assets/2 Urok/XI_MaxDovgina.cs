using UnityEngine;
using System.Collections;

public class XI_MaxDovgina : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string s = "В рядку знайти слово яке має найбільшу довжину";
		string [] str = s.Split (new char [] {' ', ',', '.', ':', '\t' });
		int maxlen =0, index = 0;
		for (int i = 0; i < str.Length; i++)
		{
			if (str[i].Length > maxlen)
			{
				maxlen = str[i].Length;
				index = i;
			}
		}
		print ("Найдовше слово: "+str[index]);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
