using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	public float yRotation = 0;
	public float xRotation = 0;
	public Camera R, L;
	Vector2 posleR = new Vector2 (0.3f, 0.3f);
	Vector2 posleL = new Vector2 (0.3f, 0.3f);
	Vector2 peredR = new Vector2 (0, 0);
	Vector2 peredL = new Vector2 (0, 0);
	int i = 0;

	// Use this for initialization
	void Start () {
 
	}
	
	// Update is called once per frame
	void Update () {
		Camera actCam = Camera.main;
		
		// activate camera
		if (Input.GetKey (KeyCode.Alpha1)) {
			actCam = L;
		}
		if (Input.GetKey (KeyCode.Alpha2)) {
			actCam = R;
		}

		actCam.transform.position += transform.TransformDirection( new Vector3 (0, 0, Input.GetAxis ("Mouse ScrollWheel")*5));

		if (Input.GetMouseButton(0)) {
			actCam.transform.position += transform.TransformDirection ( new Vector3 (Input.GetAxis("Mouse X")/10, Input.GetAxis("Mouse Y")/10, 0));
		}
		if (Input.GetMouseButton(1)) {
			xRotation = Input.GetAxis("Mouse Y");
			yRotation = Input.GetAxis("Mouse X");
			actCam.transform.Rotate(xRotation/2, yRotation/2, 0);
		}
		if ((Input.GetKeyUp(KeyCode.F1)) && (R.rect.width < 0.1f)) {
			posleR = new Vector2 (0.7f, 0.3f);
		}
		else if ((Input.GetKeyUp(KeyCode.F1)) && (R.rect.height > 0.29f)) {
			print ("?");
			posleR = new Vector2 (1f, 0.001f);
		}
		if ((Input.GetKeyUp(KeyCode.F2)) && (L.rect.width < 0.1f)) {
			posleL = new Vector2 (0.3f, 0.3f);
		}
		else if ((Input.GetKeyUp(KeyCode.F2)) && (L.rect.height > 0.29f)) {
			print ("?");
			posleL = new Vector2 (0.001f, 0.001f);
		}

		R.rect = new Rect (0.0f, Vector2.Lerp (peredR, posleR, 1/10f).x, 0.3f, Vector2.Lerp (peredR, posleR, 1/10f).y);
		L.rect = new Rect (0.7f, 0.7f, Vector2.Lerp (peredL, posleL, 1/10f).x, Vector2.Lerp (peredL, posleL, 1/10f).y);
			
		peredR = new Vector2 (R.rect.width, R.rect.height);
		peredL = new Vector2 (L.rect.width, L.rect.height);


	}
}
