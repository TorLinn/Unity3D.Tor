using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Dvig5 : MonoBehaviour
{
	public GameObject Kub;
	public GameObject Tochka;
	public Vector3 point1;
	public Vector3 point2;
	GameObject obj, objj;

	// Use this for initialization
	void Start ()
	{
		Vector3 centr = new Vector3 ((point2.x - point1.x) / 2, (point2.y - point1.y) / 2, (point2.z - point1.z) / 2) + point1;
		obj = (GameObject)Instantiate (Kub, centr, Quaternion.identity);
		obj.transform.localScale = new Vector3 ((point2.x - point1.x), (point2.y - point1.y), (point2.z - point1.z));
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			Vector3 pon = point1.RandPoint (point1, point2);
			gameObject.transform.FindChild ("Text").GetComponent<Text> ().text = pon.ToString ();
			objj = (GameObject)Instantiate (Tochka, pon, Quaternion.identity);
		}
	}
}
