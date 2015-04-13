using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Main : MonoBehaviour {

	public GameObject palka;	//коромысло
	public GameObject yadr;		//ядро
	public GameObject gru;		//противовес
	public GameObject paryadr;	// отйовская для ядер
	public Text Yadra, Sc;		//текст для пользователя
	public GameObject Cam;
	GameObject obj, objjj;
	int klik = 0;				//счетчик щелчков
	public int yadrKilk = 0;			//счетчик попыток
	Vector3 gruz, yadro, poper;	//начальные координаты
	Quaternion poperecka;		//начальный угол коромысла
	float timer = 0;			//таймер для задания промежутка между точками траэктории
	public int Score = 0;		//счетчик очков

	void Razblok (GameObject ob){
		ob.GetComponent<DistanceJoint2D>().enabled = false;
	}

	// Use this for initialization
	void Start () {
		//начальная позиция
		gruz = gru.transform.position;
		poperecka = palka.transform.rotation;
		poper = palka.transform.position;
		yadro = yadr.transform.position;
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//начальная позиция для коромысла. поставлено потому как были глюки. проверить потом !!! возможно удалить
		palka.transform.position = poper;
		//прирост таймера
		timer += Time.deltaTime; 
		//вывод текста для пользователя
		Yadra.text = " Yadra = " + yadrKilk;
		Sc.text = "Score = " + Score;

		/*//рисование траектории
		if (timer>0.1f) {
			if ((yadr.GetComponent<DistanceJoint2D>().enabled == false) && (yadr.transform.position.y>1) && (!yadr.GetComponent<Yadro>().daged)) {
				obj = (GameObject) Instantiate (traek, yadr.transform.position, Quaternion.identity);
				obj.transform.parent = put.transform;
				timer = 0;
			}
		}*/
		//по кликам мышки идет запуск катапульты
		if (Input.GetMouseButtonDown(0)) {
			if (klik == 0) {
				iTween.MoveTo (Cam, iTween.Hash("x",50, "y",45, "z",-100,"time", 1,"easetype",iTween.EaseType.easeOutQuad));
				//transform.position = new Vector3 (50,45,-100);
			}
			if (klik == 1) {
				//разблокировка коромысла
				palka.GetComponent<Rigidbody2D> ().isKinematic = false;
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
				Razblok(yadr);
				//yadr.GetComponent<DistanceJoint2D>().enabled = false;
			}
			if (klik == 3) {
				//установка начальной позиции
				palka.transform.rotation = poperecka;
				gru.transform.position = gruz;
				//возврат ядра на место
				yadr.transform.position = yadro;
				yadr.transform.rotation = Quaternion.identity;
				yadr.GetComponent<DistanceJoint2D>().enabled = true;
				yadr.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);
				yadr.GetComponent<Yadro>().daged = false;

				/*//создание нового ядра
				objjj = (GameObject) Instantiate (yadr, yadro, Quaternion.identity);
				objjj.name = "Yadro";
				objjj.transform.parent = paryadr.transform;
				objjj.GetComponent<DistanceJoint2D>().enabled = true;
				objjj.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);
				objjj.GetComponent<Yadro>().daged = false;
				yadr = objjj;*/

				palka.GetComponent<Rigidbody2D> ().isKinematic = true;
				klik = 0;
			}
			
			klik += 1;
		}

	}
}
