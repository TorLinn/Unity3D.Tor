using UnityEngine;
using System.Collections;

public class Genlev : MonoBehaviour {
	public GameObject sfera, par;
	public int grany = 5;
	GameObject [,] obj;
	Color[] cVet = {Color.red, Color.gray, Color.green, Color.blue, Color.yellow};
	
	// Use this for initialization
	void Start () {
		obj = new GameObject[grany,grany];
		for (int i = 0; i < grany; i++) {
			for (int j = 0; j < grany; j++) {
				int d = Random.Range(0, 5);
				obj[i,j] = (GameObject) Instantiate (sfera, new Vector3(i,j), new Quaternion (0,0,0,0));
				obj[i,j].transform.parent = par.transform;
				obj[i,j].name = "kub"+i+"_"+j;
				obj[i,j].GetComponent<MeshRenderer>().material.color = cVet[d];
			}
		}
		
	}


	// Update is called once per frame
	void Update () {
	
	}
}
