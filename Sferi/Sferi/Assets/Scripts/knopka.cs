using UnityEngine;
using System.Collections;

public class knopka : MonoBehaviour {

	public GameObject obgH;

	void OnMouseOver () {
		//print (obgH.GetComponent<MeshRenderer>().isVisible);
		if (gameObject.name == "up" && obgH.GetComponent<MeshRenderer>().isVisible) {
			obgH.transform.position += new Vector3 (0f, 0.1f, 0f); 
		}
		if (gameObject.name == "down" && obgH.GetComponent<MeshRenderer>().isVisible) {
			obgH.transform.position -= new Vector3 (0f, 0.1f, 0f); 
		}
		if (gameObject.name == "left" && obgH.GetComponent<MeshRenderer>().isVisible) {
			obgH.transform.position -= new Vector3 (0.1f, 0f, 0f); 
		}
		if (gameObject.name == "right" && obgH.GetComponent<MeshRenderer>().isVisible) {
			obgH.transform.position += new Vector3 (0.1f, 0f, 0f); 
		}
		if (gameObject.name == "dalche" && obgH.GetComponent<MeshRenderer>().isVisible) {
			obgH.transform.position += new Vector3 (0f, 0f, 0.1f); 
		}
		if (gameObject.name == "blige" && obgH.GetComponent<MeshRenderer>().isVisible) {
			obgH.transform.position -= new Vector3 (0f, 0f, 0.1f); 
		}
		if (obgH.GetComponent<MeshRenderer>().isVisible == false) {
			obgH.transform.position = new Vector3 (0f, 0f, 0f);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
