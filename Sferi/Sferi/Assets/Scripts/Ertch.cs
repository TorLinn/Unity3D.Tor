using UnityEngine;
using System.Collections;

public class Ertch : MonoBehaviour
{
	Vector3 aaa;

	// Use this for initialization
	void Start ()
	{
		aaa = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Rotate (0, 1f, 0); // Поворот на 1 градус
		print (transform.position);
		print (aaa);


	}
}
