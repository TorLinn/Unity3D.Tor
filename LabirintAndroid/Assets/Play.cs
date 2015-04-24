using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour
{
	public GameObject Direct;
	public GameObject CamObj;
	Quaternion ugolMax = new Quaternion (0.55f, 0, 0, 1f);
	Quaternion ugolMin = new Quaternion (-0.15f, 0, 0, 1f);
	Rigidbody rB;
	bool isZoom = false;
	float t = 0;
	float prevDist = 0;
	Vector3 zoomMin = new Vector3 (0, 2.3f, -2.3f);
	Vector3 zoomMax = new Vector3 (0, 12.5f, -20f);

	// Use this for initialization
	void Start ()
	{
		rB = GetComponent<Rigidbody> ();
		Camera.main.transform.localPosition = Vector3.Lerp (zoomMin, zoomMax, t);
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		Direct.transform.position = transform.position;
		Vector3 accel = Input.acceleration;
		rB.AddForce (Direct.transform.TransformDirection (accel.x * 50, 0, (accel.y + 0.6f) * 60));

		if (Input.touchCount == 1) {
			if (Input.GetTouch (0).phase == TouchPhase.Moved) {
				Vector2 posds = Input.GetTouch (0).deltaPosition;
				if (Mathf.Abs (posds.x) > 0.4) {
					Direct.transform.Rotate (0, posds.x / 2, 0, Space.World);
				}
				if (Mathf.Abs (posds.y) > 0.4) {
					//if (CamObj.transform.localRotation.x >= 0 && CamObj.transform.localRotation.x <= 0.5f) {
					CamObj.transform.Rotate (posds.y / 4f, 0, 0, Space.Self);
					if (CamObj.transform.localRotation.x < -0.1f) {
						CamObj.transform.localRotation = ugolMin;
					}
					if (CamObj.transform.localRotation.x > 0.5f) {
						CamObj.transform.localRotation = ugolMax;
					}
					//}
				}
			}
		}

		// Camera zoom
		if (Input.touchCount == 2) {
			if (Input.GetTouch (0).phase == TouchPhase.Moved || Input.GetTouch (1).phase == TouchPhase.Moved) {
				if (isZoom) {
					float dist = Vector2.Distance (Input.GetTouch (0).position, Input.GetTouch (1).position);
					
					if (prevDist > dist) { //zoom out
						t += dist / prevDist * 0.05f;
					}
					if (prevDist < dist) { //zoom in
						t -= prevDist / dist * 0.05f;
					}
					if (t > 1)
						t = 1f;
					if (t < 0)
						t = 0f;
					
					Camera.main.transform.localPosition = Vector3.Lerp (zoomMin, zoomMax, t);
				} else {
					isZoom = true;
					prevDist = Vector2.Distance (Input.GetTouch (0).position, Input.GetTouch (1).position);
				}
			}
		} else {
			isZoom = false;
		}
	}
}
