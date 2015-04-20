using UnityEngine;
using System.Collections;

public class cifr : MonoBehaviour {
	float timer, rand;

		// Use this for initialization
	void Start () {
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer >= 2) {
			rand = Random.Range(0f, 10f);
			gameObject.GetComponent<TextMesh>().text = string.Format("{0:0.0}", rand);
			Summ.pat.txt += rand; 
			timer = 0;
		}
	}
}
