using UnityEngine;
using System.Collections;

public class nGUI_Screen : MonoBehaviour
{

	public GameObject cam;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (gameObject.GetComponent<UISlider> ().value - 0.66f < 0.1f) {
			cam.GetComponent<Aspect> ().hir = 16f;
			cam.GetComponent<Aspect> ().vis = 9f;
		}
		if (gameObject.GetComponent<UISlider> ().value == 1f) {
			cam.GetComponent<Aspect> ().hir = 16f;
			cam.GetComponent<Aspect> ().vis = 10f;
		}
		if (gameObject.GetComponent<UISlider> ().value - 0.3f < 0.1f) {
			cam.GetComponent<Aspect> ().hir = 4f;
			cam.GetComponent<Aspect> ().vis = 3f;
		}
		if (gameObject.GetComponent<UISlider> ().value == 0f) {
			cam.GetComponent<Aspect> ().hir = 5f;
			cam.GetComponent<Aspect> ().vis = 4f;
		}
	}
}
