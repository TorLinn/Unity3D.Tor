using UnityEngine;
using System.Collections;

public class V_Rvani : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		string s;
		int dlina1 = Random.Range (1,10);
		int dlina2 = Random.Range (1,10);
		int n, min, max, povtor, stroka = 0, smin = 0, smax = 0, count = 0, serednye = 0;
		
		// ініціалізація
		int[][] mas = new int[dlina1][];
		s = "";
		for (int i = 0; i < mas.Length; i++) {
			int dlina3 = Random.Range (1,10);
			mas[i] = new int[dlina3];
			for (int j = 0; j < mas[i].Length; j++) {
				mas[i][j] = Random.Range(1,10);
				s = s+mas[i][j]+" ";
			}
			s = s + "\n";
		}
		print ("рваний масив : \n"+s);

		//середнє арифметичне
		stroka = 0;
		max = 0;
		min = 100;
		for (int i = 0; i < dlina1; i++) {
			count = 0;
			for (int j = 0; j < mas[i].Length; j++) {
				count = count + mas[i][j];
				
			}
			serednye = count / dlina2;
			print (serednye);
			if (min > serednye) {
				min = serednye;
				smin = i+1;
			}
			if (max < serednye) {
				max = serednye;
				smax = i+1;
			}
			
			serednye = 0;
		}
		print ("рядок з максимальним елементом - "+smax+", найбільший елемент - "+max+"\n"+"рядок з мінімальним елементом - "+smin+", найменший елемент - "+min);


		/*
		//знайдемо максимум
		stroka = 0;
		max = mas [0][0];
		for (int i = 0; i < dlina1; i++) {
			for (int j = 0; j < mas[i].Length; j++) {
				if (max<mas[i][j]) {
					max = mas[i][j];
					stroka = i+1;
				}
			}
		}
		print ("рядок з максимальним елементом - "+stroka+", найбільший елемент - "+max);

		//знайдемо мінімум
		stroka = 0;
		min = mas [0][0];
		for (int i = 0; i < dlina1; i++) {
			for (int j = 0; j < mas[i].Length; j++) {
				if (min>mas[i][j]) {
					min = mas[i][j];
					stroka = i+1;
				}
			}
		}
		print ("рядок з мінімальним елементом - "+stroka+", найменший елемент - "+min);


		//найбільш повторювані символи
		povtor = 0;
		count = 0;
		for (int i = 0; i < dlina1; i++) {
			for (int j = 0; j < mas[i].Length; j++) {
				n = mas[i][j];
				for (int l = 0; l < mas[i].Length; l++) {
					if (n == mas[i][l]) {
						povtor = povtor + 1;
					}
				}
				if (count<povtor) {
					count = povtor;
					stroka = i+1;
				}
				povtor = 0;
			}
		}
		print ("povtori = "+count+", stroka = "+stroka);

		*/
	}
		
	// Update is called once per frame
	void Update () {
	
	}
}
