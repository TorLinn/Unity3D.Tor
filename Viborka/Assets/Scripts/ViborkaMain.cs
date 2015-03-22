using UnityEngine;
using System.Collections;

public class ViborkaMain : MonoBehaviour {

	public GameObject [] fig = new GameObject[7];
	GameObject obj;
	public int [] razm = new int[7];

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 7; i++) {
			razm[i] = Random.Range(5,7);
		}
		for (int i = 0; i < 7; i++) {
			for (int j = 0; j < razm[i]; j++) {
				obj = (GameObject)Instantiate (fig[i], new Vector3 (Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0), new Quaternion (0f, 0f, 0f, 0f));
				obj.name = fig[i].name + "_" + j;
				obj.transform.parent = transform;
			}
		}

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
