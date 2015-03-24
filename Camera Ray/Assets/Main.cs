using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	public float yRotation = 0;
	public float xRotation = 0;
	public Camera R, L;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position += new Vector3 (0, 0, Input.GetAxis ("Mouse ScrollWheel"));
		/*if (Input.GetMouseButton (0)) { // Move Player object
			Camera.main.transform.position = (Vector2)Camera.main.ScreenToWorldPoint (Input.mousePosition);
		}*/
		if (Input.GetMouseButton(0)) {
			transform.position += new Vector3 (Input.GetAxis("Mouse X")/10, Input.GetAxis("Mouse Y")/10, 0);
		}
		if (Input.GetMouseButton(1)) {
			xRotation += Input.GetAxis("Mouse Y");
			yRotation -= Input.GetAxis("Mouse X");
			transform.eulerAngles = new Vector3(xRotation, yRotation, 0);
		}
		if ((Input.GetKeyUp(KeyCode.F1)) && (R.rect.width == 0)) {
			print ("!");
			Vector2 pered = new Vector2 (0, 0);
			Vector2 posle = new Vector2 (0.4f, 0.4f);
			R.rect = new Rect (0.1f, 0.5f, Vector2.Lerp (pered,posle,1f).x, Vector2.Lerp (pered,posle,1f).y);
		}
		else if ((Input.GetKeyUp(KeyCode.F1)) && (R.rect.height != 0)) {
			print ("?");
			Vector4 posle = new Vector4(0.1f, 0.5f, 0, 0);
			Vector4 pered = new Vector4(0.1f, 0.5f, 0.4f, 0.4f);
			R.rect = new Rect (Vector4.Lerp (pered,posle,20f).x, Vector4.Lerp (pered,posle,20f).y, Vector4.Lerp (pered,posle,20f).w, Vector4.Lerp (pered,posle,20f).z);
		}

	}
}
