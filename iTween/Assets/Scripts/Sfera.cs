using UnityEngine;
using System.Collections;

public class Sfera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 10; i++) {
			if (i%2 == 0) {
				iTween.MoveAdd (gameObject, iTween.Hash("x",1,"y",2,"time",1,"delay",i,"easetype",iTween.EaseType.easeOutQuad));
			}
			else {
				iTween.MoveAdd (gameObject, iTween.Hash("x",1,"y",-2,"time",1,"delay",i-0.045f,"easetype",iTween.EaseType.easeInQuad));
			}
			iTween.ColorTo (gameObject, iTween.Hash ("r", Random.Range(0,1f),"g",Random.Range(0,1f),"b",Random.Range(0,1f), "time", 1, "easetype", iTween.EaseType.linear,"delay",i));
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
