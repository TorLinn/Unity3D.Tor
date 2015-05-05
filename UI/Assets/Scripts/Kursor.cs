using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Kursor : MonoBehaviour
{

	public bool kliked = false;
	public GameObject temp;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position = Input.mousePosition + new Vector3 (-50f, 0, 0);
		if (GetComponent<Image> ().sprite == null) {
			GetComponent<Image> ().color = new Color (1f, 1f, 1f, 0f);
		}
	}
}
