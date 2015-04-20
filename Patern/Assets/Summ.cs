using UnityEngine;
using System.Collections;

public class Summ : MonoBehaviour {
	public float txt;
	public static Summ pat{ get; private set; } 
	
	void Awake () {
		pat = this;
	}

	// Use this for initialization
	void Start () {
		txt = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<TextMesh>().text = string.Format("{0:0.0}", txt);
	
	}
}
