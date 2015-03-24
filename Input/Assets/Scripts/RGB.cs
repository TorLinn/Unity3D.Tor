using UnityEngine;
using System.Collections;

public class RGB : MonoBehaviour {
	public Transform R, G, B;
	float distR, distG, distB, summ;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0)) {
			transform.position += new Vector3 (Input.GetAxis("Mouse X")/3, Input.GetAxis("Mouse Y")/3, 0);
		}
		distR = Vector3.Distance (R.position, transform.position);
		distG = Vector3.Distance (G.position, transform.position);
		distB = Vector3.Distance (B.position, transform.position);
		summ = distR + distG + distB;
		print (distR+" "+distG+" "+distB);
		transform.GetComponent<SpriteRenderer> ().color = new Color ((10-distR)/10, (10-distG)/10, (10-distB)/10);

	
	}
}
