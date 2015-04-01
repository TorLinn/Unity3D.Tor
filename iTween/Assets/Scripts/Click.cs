using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {
	public GameObject obj;
	GameObject obJ;


	// Use this for initialization
	void Start () {

		iTween.MoveAdd (gameObject, iTween.Hash("x",Random.Range (-2f, 2f),"y",Random.Range (-2f, 2f),"z",Random.Range (-2f, 2f), "time", 3, "easetype",iTween.EaseType.easeOutQuad));
		iTween.RotateAdd (gameObject, iTween.Hash("x", Random.Range(0,1f)*360,"y", Random.Range(0,1f)*360,"z", Random.Range(0,1f)*360, "time", 4, "easetype", iTween.EaseType.linear,"looptype", iTween.LoopType.pingPong));
			//iTween.ScaleTo (obJ, iTween.Hash("x",2,"y",2,"z",2,"time",3, "easetype", iTween.EaseType.easeOutQuad));


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
