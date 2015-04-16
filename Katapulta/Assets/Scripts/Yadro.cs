using UnityEngine;
using System.Collections;

public class Yadro : MonoBehaviour {
	public bool daged = false;		//перемення для указания бил ли удар ядра о другие обьекти
	public GameObject traek; 		//префаб траэктории
	public GameObject vzriv;		//префаб партикла взрива
	float timer;
	GameObject obj;					//обьект которий создается при рісовании траєктории
	GameObject vz;					//создаем визуализацию взрива на основе партикла
	bool vzr = true;				//переменная для неповторенія взрива

	void OnCollisionEnter2D (Collision2D сol){
		daged = true;
		if (vzr == true) {
			vz = (GameObject) Instantiate (vzriv, transform.position, Quaternion.identity);
			vzr = false;
			Destroy(vz,1f);
			Vector2 forc = new Vector2 (2000f, 2000f);
			Vector2 pos = gameObject.transform.position;
			gameObject.GetComponent<Rigidbody2D>().AddForceAtPosition (forc, pos, ForceMode2D.Impulse);
		}

	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		timer += Time.deltaTime; 

		//рисование траектории
		if (timer>0.1f) {
			if ((GetComponent<DistanceJoint2D>().enabled == false) && (transform.position.y>0.1f) && (!GetComponent<Yadro>().daged)) {
				obj = (GameObject) Instantiate (traek, transform.position, Quaternion.identity);
				//для лучшего контроля все обьекти траєктории вкладиваем в отцовский
				obj.transform.parent = GameObject.Find("traektor").transform;
				timer = 0;
			}
		}
	}
}
