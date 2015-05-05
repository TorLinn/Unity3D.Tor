//	Дано чотирьох значне число. Визначити чи всі цифри в числі різні (4213 – різні, 2343 – не різні).

using UnityEngine;
using System.Collections;

public class Zavd1 : MonoBehaviour
{

	public int a = 1000;
	int[] mas = new int[4];
	int b = 1000;
	bool rizni = true;

	// Use this for initialization
	void Start ()
	{
		for (int i = 0; i < mas.Length; i++) {
			mas [i] = a / b;
			a -= b * mas [i];
			b /= 10;
		}
		for (int i = 0; i < mas.Length - 1; i++) {
			for (int j = i + 1; j < mas.Length; j++) {
				if (mas [i] == mas [j]) {
					rizni = false;
				}
			}
		}
		if (rizni) {
			print ("Знаки різні");
		} else {
			print ("Є однакові знаки");
		}
	}

	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
