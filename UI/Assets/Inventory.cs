using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

	public GameObject kur;
	public GameObject icon;
	public GameObject temp;

	public void Klik ()
	{
		if (kur.GetComponent<Kursor> ().kliked == false) {
			temp = gameObject;
			kur.GetComponent<Image> ().sprite = GetComponent<Image> ().sprite;
			kur.GetComponent<Image> ().color = new Color (1f, 1f, 1f, 1f);
			kur.GetComponent<Kursor> ().kliked = true;
		} else {
				
		}

	}

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
