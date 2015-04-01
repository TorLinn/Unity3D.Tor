using UnityEngine;
using System.Collections;

public class KubStvor : MonoBehaviour {
	public GameObject Kub, par;
	public int grany = 3;
	GameObject [,,] obj;

	// Use this for initialization
	void Start () {
		obj = new GameObject[grany,grany,grany];
		for (int i = 0; i < grany; i++) {
			for (int j = 0; j < grany; j++) {
				for (int l = 0; l < grany; l++) {
					obj[i,j,l] = (GameObject) Instantiate (Kub, new Vector3(i,j,l), new Quaternion (0,0,0,0));
					obj[i,j,l].transform.parent = par.transform;
					obj[i,j,l].name = "kub"+i+"_"+j+"_"+l;
					obj[i,j,l].GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0,1f),Random.Range(0,1f),Random.Range(0,1f));
				}
			}
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray luch = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (luch, out hit, 100f)) {
				if (hit.collider.tag == "Kub") {
					for (int i = 0; i < grany; i++) {
						for (int j = 0; j < grany; j++) {
							for (int l = 0; l < grany; l++) {
								iTween.MoveAdd (obj[i,j,l], iTween.Hash("x", Random.Range(-3f,3f),
								                                        "y", Random.Range(-3f,3f),
								                                        "z", Random.Range(-3f,3f),
								                                        "easetype", iTween.EaseType.easeOutCubic));
							}
						}
					}
				}
			}
		}
	
	}
}
