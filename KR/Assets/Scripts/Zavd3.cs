//	Дано масив цілих чисел. Знайти суму кратних заданому a.

using UnityEngine;
using System.Collections;

public class Zavd3 : MonoBehaviour
{

	public int a;
	int summ = 0;
	int[] mas = new int[20];

	// Use this for initialization
	void Start ()
	{
		for (int i = 0; i < mas.Length; i++) {
			mas [i] = Random.Range (1, 100);
		}
		for (int i = 0; i < mas.Length; i++) {
			if (mas [i] % a == 0) {
				summ += mas [i];
			}
		}
		print ("Сума = " + summ);
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
