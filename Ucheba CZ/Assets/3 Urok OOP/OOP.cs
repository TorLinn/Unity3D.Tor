using UnityEngine;
using System.Collections;

//створення класу - людина
public class Adress {
	public int index;
	public string strana;
	public string misto;
	public string vul;
	public int nomer;
}

public class Humans:Adress {
	public string fio;
	private int pol;
	public int Pol {
		get { return pol; }
		set { if (value == 1 || value == 2 )	pol = value; }
	}
	private int vik;
	public int Vik {
		get { return vik; }
		set { if (value < 115 && value > 0)	vik = value; }
	}
	public float rost;

	//конструктор нового обєкту по-замовчуванню
	public Humans (){
		fio = "FIO";
		Pol = Random.Range(1,3);
		Vik = Random.Range(1,115);
		rost = Random.Range(100,250);
		index = 33000;
		strana = "Україна";
		misto = "Рівне";
		vul = "Соборна";
		nomer = 155;
	}

	//конструктор вводу информації
	public Humans (string _fio, int _pol, int _vik, float _rost){
		fio = _fio;
		Pol = _pol;
		Vik = _vik;
		rost = _rost;
	}

	//вивід значення
	public void VivodZmina(){
		string pols = "";
		if (pol == 1) {
			pols = "чоловік";
		}
		else {
			pols = "жінка";
		}
		Debug.Log ("FIO = "+fio+" Pol = "+pols+" Vik = "+vik+" Rost = "+rost+" індекс = "+index);
	}

	//вівид певного значення
	public void VivodZmina (string CU) {
		switch (CU) {
			case "FIO": {
				Debug.Log("Fio = "+fio);
				break;
			}
		}
	}

	//зміна значення
	public void VivodZmina (string Cu, string Zmina){
		switch (Cu) {
		case "FIO": {
			fio = Zmina;
			break;
		}
		}
	}
	//зміна значення
	public void VivodZmina (string Ku, int ZZmina){
		switch (Ku) {
		case "Pol": {
			Pol = ZZmina;
			break;
		}
		case "Vik": {
			Vik = ZZmina;
			break;
		}
		case "Rost": {
			rost = ZZmina;
			break;
		}
		}
	}
}

public class OOP : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string fi = "";
		int lon = Random.Range (8,20);
		Humans[] units = new Humans[lon];
		units[0] = new Humans ();
		units[1] = new Humans ("Ivanov Ivan",1,30,170);
		for (int i = 0; i < units.Length; i++) {
			fi = "FIO_"+i;
			units[i] = new Humans();
			units[i].fio = fi;
		}

		// вибірка на проміжок від 18 до 65 років
		for (int i = 0; i < units.Length; i++) {
			if (units[i].Vik <66 && units[i].Vik>17) {
				units[i].VivodZmina();
			}
		}

		//знаходження старшого
		int max = 0, k = 0;
		for (int i = 0; i < units.Length; i++) {
			if (max < units[i].Vik) {
				max = units[i].Vik;
				k = i;
			}
		}
		//print ("найстарший = "+units[k].fio+" вік = "+units[k].Vik);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
