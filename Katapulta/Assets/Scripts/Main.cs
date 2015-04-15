using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Main : MonoBehaviour {

	public GameObject palka;	//коромысло
	public GameObject [] yadr;	//ядро
	public GameObject gru;		//противовес
	public GameObject paryadr;	// отцовская для ядер
	public Text Yadra, Sc;		//текст для пользователя
	public GameObject Cam;		//камера - для ее плавного управления
	int klik = -1;				//счетчик щелчков
	public int yadrKilk = 0;	//счетчик попыток
	Vector3 gruz, yadro, poper;	//начальные координаты
	Quaternion poperecka;		//начальный угол коромысла
	public int Score = 0;		//счетчик очков
	public int i = 0;			//индекс для определения типа ядра

	void OnMouseDown () {


		klik += 1;
		//по кликам мышки идет запуск катапульты
		/*if (Input.GetMouseButtonDown(0)) {*/
		if (klik == 0) {
			iTween.MoveTo (Cam, iTween.Hash("x",50, "y",45, "z",-100,"time", 1,"easetype",iTween.EaseType.easeOutQuad));
			//transform.position = new Vector3 (50,45,-100);
			print ("0");
		}
		if (klik == 1) {
			//разблокировка коромысла
			palka.GetComponent<Rigidbody2D> ().isKinematic = false;
			print ("1");
		}
		if (klik == 2) {
			//уничтожение предыдущей траектории
			GameObject[] traks = GameObject.FindGameObjectsWithTag ("traektoriya");
			foreach (var trak in traks) {
				Destroy(trak);
			}
			//количесвто кинутых ядер
			yadrKilk +=1;
			//разблокировка ядра
			Razblok(GameObject.Find("Yadro"));
			//yadr.GetComponent<DistanceJoint2D>().enabled = false;
			print ("2");
		}
		if (klik == 3) {
			//установка начальной позиции
			palka.transform.rotation = poperecka;
			gru.transform.position = gruz;

			//создание нового ядра
			Stvor();

			palka.GetComponent<Rigidbody2D> ().isKinematic = true;
			klik = 0;
			print ("3");
		}
	}

	void Razblok (GameObject ob){
		ob.GetComponent<DistanceJoint2D>().enabled = false;
		ob.name = "YAdro Razblok";
	}

	public void SetI (int j){
		i=j;
	}

	public void Stvor () {
		Destroy(GameObject.Find("Yadro"));
		GameObject yadrn  = (GameObject) Instantiate (yadr[i], new Vector3 (-11.285f, 0.81f, 0), Quaternion.identity);
		yadrn.name = "Yadro";
		yadrn.transform.parent = paryadr.transform;
		yadrn.GetComponent<DistanceJoint2D>().enabled = true;
		yadrn.GetComponent<DistanceJoint2D>().connectedBody = palka.GetComponent<Rigidbody2D>();
		yadrn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);
		yadrn.GetComponent<Rigidbody2D>().drag = 0f;
		yadrn.GetComponent<Yadro>().daged = false;

	}

	// Use this for initialization
	void Start () {
		//созданіе начального ядра
		Stvor();
		//начальная позиция
		gruz = gru.transform.position;
		poperecka = palka.transform.rotation;
		poper = palka.transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		//начальная позиция для коромысла. поставлено потому как были глюки. проверить потом !!! возможно удалить
		palka.transform.position = poper;
		//вывод текста для пользователя
		Yadra.text = " Yadra = " + yadrKilk;
		Sc.text = "Score = " + Score;
	}
}
