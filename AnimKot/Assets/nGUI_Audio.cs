using UnityEngine;
using System.Collections;

public class nGUI_Audio : MonoBehaviour
{

	public GameObject aud;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		aud.GetComponent<AudioSource> ().volume = gameObject.GetComponent<UISlider> ().value;
	}
}
