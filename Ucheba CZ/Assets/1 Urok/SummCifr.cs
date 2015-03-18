using UnityEngine;
using System.Collections;

public class SummCifr : MonoBehaviour {
	public int cifr;
	int summ, a ,b , c, d;

	// Use this for initialization
	void Start () {
		a = cifr / 1000;
		b = (cifr - a * 1000) / 100;
		c = (cifr - (a * 1000 + b * 100)) / 10;
		d = cifr - (a * 1000 + b * 100 + c * 10);
		summ = a + b + c + d;
		print (summ);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
