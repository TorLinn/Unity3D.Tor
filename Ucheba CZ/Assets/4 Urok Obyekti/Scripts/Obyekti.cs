using UnityEngine;
using System.Collections;

public class Obyekti : MonoBehaviour
{

	public GameObject koll;
	public static int Count;
	float randx, randy, randz;

	GameObject obj;
	int time, i;
	float timer, timer2;

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		time = Random.Range (2, 5);
		timer += Time.deltaTime;
		timer2 += Time.deltaTime;
		if (time < timer) {
			timer = 0;

			randx = Random.Range (-10, 11);
			randy = Random.Range (-3, 4);
			randz = Random.Range (0, 7);
			obj = (GameObject)Instantiate (koll, new Vector3 (randx, randy, randz), new Quaternion (0f, 0f, 0f, 0f));
			obj.transform.parent = transform;

		}

		if (timer2 >= 40) {
			print (Count);
			Destroy (gameObject);
		}

	}
}
