using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

	public GameObject kur;
	public GameObject icon;

	public void Klik ()
	{
		if (kur.GetComponent<Kursor> ().kliked == false) {
			kur.GetComponent<Kursor>().temp = gameObject;
			kur.GetComponent<Image> ().sprite = GetComponent<Image> ().sprite;
			kur.GetComponent<Image> ().color = new Color (1f, 1f, 1f, 1f);
			GetComponent<Image> ().sprite = null;
			kur.GetComponent<Kursor> ().kliked = true;
		} else {
			if (kur.GetComponent<Kursor>().temp != null) {
				kur.GetComponent<Kursor>().temp.GetComponent<Image>().sprite = GetComponent<Image> ().sprite;
				kur.GetComponent<Kursor>().temp.GetComponent<Image>().color = new Color (1f, 1f, 1f, 1f);
			}
			kur.GetComponent<Kursor>().temp = null;
			GetComponent<Image> ().sprite = kur.GetComponent<Image> ().sprite;
			GetComponent<Image> ().color = new Color (1f, 1f, 1f, 1f);
			kur.GetComponent<Image> ().sprite = null;
			kur.GetComponent<Kursor> ().kliked = false;
		}

	}

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (GetComponent<Image> ().sprite == null) {
			GetComponent<Image> ().color = new Color (1f, 1f, 1f, 0f);
		}
	}
}
