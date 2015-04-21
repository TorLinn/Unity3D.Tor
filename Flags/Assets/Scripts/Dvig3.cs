using UnityEngine;
using System.Collections;

public class Dvig3 : MonoBehaviour
{
	public GameObject CubB;
	public GameObject CubS;
	float f = 0;

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		f += Time.deltaTime;
		CubB.transform.setX (f);
		CubB.transform.setZ (f);
		CubS.transform.setY ("l", f);
	}
}
