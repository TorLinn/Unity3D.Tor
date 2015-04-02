using UnityEngine;
using System.Collections;

public class Genlev : MonoBehaviour {
	public GameObject sfera;
	public static int grany = 9;
	public static GameObject [,] obj;
	Color[] cVet = {Color.red, Color.gray, Color.green, Color.blue, Color.yellow};

	// Use this for initialization
	void Start () {
		obj = new GameObject[grany,grany];
		for (int i = 0; i < grany; i++) {
			for (int j = 0; j < grany; j++) {
				int d = Random.Range(0, 5);
				obj[i,j] = (GameObject) Instantiate (sfera, new Vector3(i,j), new Quaternion (0,0,0,0));
				obj[i,j].transform.parent = gameObject.transform;
				obj[i,j].name = string.Format ("c_{0:00}_{1:00}", i, j);
				obj[i,j].GetComponent<MeshRenderer>().material.color = cVet[d];
			}
		}
	}

	// Update is called once per frame
	void Update () {
		for (int i = 0; i < grany; i++) {
			for (int j = 0; j < grany; j++) {
				if (obj[i,j].GetComponent<MeshRenderer>().material.color != Color.clear) {
					poisk (i,j,obj[i,j].GetComponent<MeshRenderer>().material.color);
				}
					
			}
		}
	
	}

	private void poisk (int f, int z, Color colLor) {
		Color tempC = colLor;
		if ((z - 1 >= 0) && (tempC == obj [f, z - 1].GetComponent<MeshRenderer>().material.color)) {
			obj [f, z - 1].GetComponent<MeshRenderer>().material.color = Color.clear;
			obj [f , z].GetComponent<MeshRenderer>().material.color = Color.clear;
			Destroy(obj [f, z - 1]);
			Destroy(obj [f , z]);
			poisk (f,z-1,tempC);
		}
		if ((z + 1 < grany) && (tempC == obj [f, z + 1].GetComponent<MeshRenderer>().material.color)) {
			obj [f,z+1].GetComponent<MeshRenderer>().material.color = Color.clear;
			obj [f , z].GetComponent<MeshRenderer>().material.color = Color.clear;
			poisk (f,z+1,tempC);
		}
		if ((f - 1 >= 0) && (tempC == obj [f - 1, z].GetComponent<MeshRenderer>().material.color)) {
			obj [f - 1, z].GetComponent<MeshRenderer>().material.color = Color.clear;
			obj [f , z].GetComponent<MeshRenderer>().material.color = Color.clear;
			poisk (f-1,z,tempC);
		}
		if ((f + 1 < grany) && (tempC == obj [f + 1, z].GetComponent<MeshRenderer>().material.color)) {
			obj [f + 1, z].GetComponent<MeshRenderer>().material.color = Color.clear;
			obj [f, z].GetComponent<MeshRenderer>().material.color = Color.clear;
			poisk (f + 1, z, tempC);
		}
	}	
}
