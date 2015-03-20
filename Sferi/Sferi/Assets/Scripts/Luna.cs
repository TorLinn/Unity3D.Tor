using UnityEngine;
using System.Collections;

public class Luna : MonoBehaviour {

	//public Transform ertch;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 2f, 0); // Поворот на 1 градус
		//transform.LookAt (ertch); // Поточний об'єкт дивіться на obj
		//transform.localPosition -= new Vector3 (0f, 0.1f, 0f);
	}
}
