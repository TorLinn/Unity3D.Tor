using UnityEngine;
using System.Collections;

public class XIV_NapisSlovami : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int chislo = Random.Range (1,100);
		int pslovo = 0, slovo = 0;
		print ("обране число = "+chislo);
		string s = chislo.ToString();
		string ss = "";

		pslovo = chislo / 10;
		slovo = chislo % 10;


		if (chislo > 10 && chislo < 20) {
			switch (chislo) {
			case 11:
				ss = ss + "одинадцять";
				break;
			case 12:
				ss = ss + "дванадцять";
				break;
			case 13:
				ss = ss + "тринадцять";
				break;
			case 14:
				ss = ss + "чотирнадцять";
				break;
			case 15:
				ss = ss + "п'ятнадцять";
				break;
			case 16:
				ss = ss + "шістнадцять";
				break;
			case 17:
				ss = ss + "сімнадцять";
				break;
			case 18:
				ss = ss + "вісімнадцять";
				break;
			case 19:
				ss = ss + "дев'ятнадцять";
				break;
			default:
				break;
			}
		}
		else {
				switch (pslovo) 
				{
				case 1:
					ss = ss + "десять";
					break;
				case 2:
					ss = ss + "двадцять";
					break;
				case 3:
					ss = ss + "тридцять";
					break;
				case 4:
					ss = ss + "сорок";
					break;
				case 5:
					ss = ss + "п'ятдесят";
					break;
				case 6:
					ss = ss + "шістдесят";
					break;
				case 7:
					ss = ss + "сімдесят";
					break;
				case 8:
					ss = ss + "вісімдесят";
					break;
				case 9:
					ss = ss + "дев'яносто";
					break;
				default:
					break;
				}

				switch (slovo) 
				{
				case 1:
					ss = ss + " один";
					break;
				case 2:
					ss = ss + " два";
					break;
				case 3:
					ss = ss + " три";
					break;
				case 4:
					ss = ss + " чотири";
					break;
				case 5:
					ss = ss + " п'ять";
					break;
				case 6:
					ss = ss + " шість";
					break;
				case 7:
					ss = ss + " сім";
					break;
				case 8:
					ss = ss + " вісім";
					break;
				case 9:
					ss = ss + " дев'ять";
					break;
				default:
					break;
				}
		}
		

		print (ss);

	}

	// Update is called once per frame
	void Update () {
	
	}
}
