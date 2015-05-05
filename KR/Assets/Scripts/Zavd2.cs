// Знайти суму 12 + 22 +32 + … +n2 , де 5<n<20.

using UnityEngine;
using System.Collections;

public class Zavd2 : MonoBehaviour
{
	float summ = 0;
	// Use this for initialization
	void Start ()
	{
		int n = Random.Range (4, 20);
		print ("n = " + n);
		for (int i = 1; i <= n; i++) {
			summ += i * i;
		}
		print ("сума = " + summ);
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
