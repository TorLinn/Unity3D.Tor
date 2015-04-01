using UnityEngine;
using System.Collections;

public class Fin : MonoBehaviour {
	public GameObject play1, play2, textB;


	void OnTriggerEnter2D (Collider2D col)
	{
		col.tag = "Finish";
		if ((play1.tag == "Finish") && (play2.tag == "Finish")) {
			textB.GetComponent<GUIText>().text = "Bingo!!!";
			play1.SetActive(false);
			play2.SetActive(false);
		}
	}
	void OnTriggerExit2D (Collider2D col)
	{
		col.tag = "Player";
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
}
