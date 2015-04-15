using UnityEngine;
using System.Collections;

public class Sdvig : MonoBehaviour {
	public GameObject htxt;	//вспливающий текст
	GameObject neo;
	GameObject obj;			//обьект для передачи очков в основной скрипт
	float x,y,z;			//сюда записать начальние координати, по которим потом можно вичислять сдвиг
	bool kilk = true; 		//переключатель для одноразового начисления очек

	// Use this for initialization
	void Start () {
		//начальная позиция
		x = transform.position.x;
		y = transform.position.y;
		z = transform.position.z;
		obj = GameObject.Find("Script");
	}
	
	// Update is called once per frame
	void Update () {
		if (kilk == true) {
			if (Mathf.Abs(x - transform.position.x)>1) {
				obj.GetComponent<Main>().Score += 100; 
				kilk = false;
				neo = (GameObject) Instantiate (htxt, new Vector3 (x,y+1,z), Quaternion.identity);
				Destroy(neo, 2);
			}
		}

	}
}
