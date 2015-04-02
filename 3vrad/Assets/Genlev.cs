using UnityEngine;
using System.Collections;

public class Genlev : MonoBehaviour {
	public GameObject sfera;
	GameObject selected=null;
	public static int grany = 9;
	public static GameObject [,] obj;
	Color[] cVet = {Color.red, Color.white, Color.green, Color.cyan, Color.yellow};

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
		if (Input.GetMouseButtonDown (0)) {
			Ray luch = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (luch, out hit, 100f)) {

				if ((selected != null) && (selected.transform.position != hit.collider.transform.position) &&(Vector3.Distance(selected.transform.position, hit.collider.transform.position)<=1)) {
					Vector3 sectPos = selected.transform.position;
					Vector3 hitPos = hit.collider.transform.position;
					Vector3 [] path1 = new Vector3[3];
					path1 [0] = new Vector3 (sectPos.x, sectPos.y, sectPos.z-1);
					path1 [1] = new Vector3 (hitPos.x, hitPos.y, hitPos.z-1);
					path1 [2] = new Vector3 (hitPos.x, hitPos.y, hitPos.z);
					Vector3 [] path2 = new Vector3[3];
					path2 [0] = new Vector3 (hitPos.x, hitPos.y, hitPos.z+1);
					path2 [1] = new Vector3 (sectPos.x, sectPos.y, sectPos.z+1);
					path2 [2] = new Vector3 (sectPos.x, sectPos.y, sectPos.z);
					iTween.MoveTo (selected, iTween.Hash("path", path1, "time", 1f, "easetype", iTween.EaseType.easeInSine));
					iTween.MoveTo (hit.collider.gameObject, iTween.Hash("path", path2, "time", 1f, "easetype", iTween.EaseType.easeInSine, "oncomplete", "DropCirles", 
					                                                    "oncompletetarget", hit.collider.transform.parent.gameObject));
					iTween.RotateTo (selected, iTween.Hash("z", 0));
					for (int i = 0; i < grany; i++) {
						for (int j = 0; j < grany; j++) {
							if (obj [i, j] == selected)
								obj [i, j] = hit.collider.gameObject;
							else if (obj [i, j] == hit.collider.gameObject)
								obj [i, j] = selected;
						}
					}
					selected = null;
					//DropCirles ();
					return;
				}
				else if ((selected != null) && (Vector3.Distance(selected.transform.position, hit.collider.transform.position)>1)) {
					iTween.RotateTo (selected, iTween.Hash("z", 0));
					selected = null;
				}
				if (selected == null) {
					selected = hit.collider.gameObject;
					selected.transform.position = hit.collider.gameObject.transform.position;
					iTween.RotateTo (selected, iTween.Hash("z", 180, "time", 1, "easetype", iTween.EaseType.linear,"looptype", iTween.LoopType.loop));
				}

			}
		}
	}

	/*private void poisk (int f, int z, Color colLor) {
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
			Destroy(obj [f, z + 1]);
			Destroy(obj [f , z]);
			poisk (f,z+1,tempC);
		}
		if ((f - 1 >= 0) && (tempC == obj [f - 1, z].GetComponent<MeshRenderer>().material.color)) {
			obj [f - 1, z].GetComponent<MeshRenderer>().material.color = Color.clear;
			obj [f , z].GetComponent<MeshRenderer>().material.color = Color.clear;
			Destroy(obj [f-1, z]);
			Destroy(obj [f , z]);
			poisk (f-1,z,tempC);
		}
		if ((f + 1 < grany) && (tempC == obj [f + 1, z].GetComponent<MeshRenderer>().material.color)) {
			obj [f + 1, z].GetComponent<MeshRenderer>().material.color = Color.clear;
			obj [f, z].GetComponent<MeshRenderer>().material.color = Color.clear;
			Destroy(obj [f+1, z]);
			Destroy(obj [f , z]);
			poisk (f + 1, z, tempC);
		}
	}*/
	void DropCirles ()
	{	
		for (int i = 0; i < grany; i++) {
			for (int j = 0; j < grany; j++) {
				Color myColor = obj [i, j].GetComponent<MeshRenderer> ().material.color;
				if (j < grany - 2) {
					if (obj [i, j + 1].GetComponent<MeshRenderer> ().material.color == myColor && obj [i, j + 2].GetComponent<MeshRenderer> ().material.color == myColor) {
						Vector3 pos1 = obj[i,j].transform.position;
						Destroy(obj [i, j]);
						obj[i,j] = (GameObject) Instantiate (sfera, pos1, new Quaternion (0,0,0,0));
						obj[i,j].GetComponent<MeshRenderer>().material.color = cVet[Random.Range(0, 5)];
						//iTween.MoveTo(obj[i,j], iTween.Hash("z",0, "time", 1));
						Vector3 pos2 = obj[i,j+1].transform.position;
						Destroy(obj [i, j+1]);
						obj[i,j+1] = (GameObject) Instantiate (sfera, pos2, new Quaternion (0,0,0,0));
						obj[i,j+1].GetComponent<MeshRenderer>().material.color = cVet[Random.Range(0, 5)];
						Vector3 pos3 = obj[i,j+2].transform.position;
						Destroy(obj [i, j+2]);
						obj[i,j+2] = (GameObject) Instantiate (sfera, pos3, new Quaternion (0,0,0,0));
						obj[i,j+2].GetComponent<MeshRenderer>().material.color = cVet[Random.Range(0, 5)];
						//iTween.RotateAdd (obj [i, j], iTween.Hash ("y", 360, "time", 2, "looptype", iTween.LoopType.loop, "easetype", iTween.EaseType.linear));
						//iTween.RotateAdd (obj [i, j + 1], iTween.Hash ("y", 360, "time", 2, "looptype", iTween.LoopType.loop, "easetype", iTween.EaseType.linear));
						//iTween.RotateAdd (obj [i, j + 2], iTween.Hash ("y", 360, "time", 2, "looptype", iTween.LoopType.loop, "easetype", iTween.EaseType.linear));
					}
				}
				if (i < grany - 2) {
					if (obj [i + 1, j].GetComponent<MeshRenderer> ().material.color == myColor && obj [i + 2, j].GetComponent<MeshRenderer> ().material.color == myColor) {
						Vector3 pos4 = obj[i,j].transform.position;
						Destroy(obj [i, j]);
						obj[i,j] = (GameObject) Instantiate (sfera, pos4, new Quaternion (0,0,0,0));
						obj[i,j].GetComponent<MeshRenderer>().material.color = cVet[Random.Range(0, 5)];
						Vector3 pos5 = obj[i+1,j].transform.position;
						Destroy(obj [i+1, j]);
						obj[i+1,j] = (GameObject) Instantiate (sfera, pos5, new Quaternion (0,0,0,0));
						obj[i+1,j].GetComponent<MeshRenderer>().material.color = cVet[Random.Range(0, 5)];
						Vector3 pos6 = obj[i+2,j].transform.position;
						Destroy(obj [i+2, j]);
						obj[i+2,j] = (GameObject) Instantiate (sfera, pos6, new Quaternion (0,0,0,0));
						obj[i+2,j].GetComponent<MeshRenderer>().material.color = cVet[Random.Range(0, 5)];
						//iTween.RotateAdd (obj [i, j], iTween.Hash ("y", 360, "time", 2, "looptype", iTween.LoopType.loop, "easetype", iTween.EaseType.linear));
						//iTween.RotateAdd (obj [i + 1, j], iTween.Hash ("y", 360, "time", 2, "looptype", iTween.LoopType.loop, "easetype", iTween.EaseType.linear));
						//iTween.RotateAdd (obj [i + 2, j], iTween.Hash ("y", 360, "time", 2, "looptype", iTween.LoopType.loop, "easetype", iTween.EaseType.linear));
					}	
				}
			}
		}
	}
}
