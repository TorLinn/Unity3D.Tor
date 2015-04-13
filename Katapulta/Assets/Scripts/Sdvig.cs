using UnityEngine;
using System.Collections;

public class Sdvig : MonoBehaviour {
	GameObject obj;
	float x,y,z;
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
			}
		}

	}
}
