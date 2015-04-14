using UnityEngine;
using System.Collections;

public class Triger : MonoBehaviour {
	GameObject obj, objn;
	public GameObject yadrr, paren, palk;

	public void KliKK () {
		print ("!");
		obj = GameObject.Find("Yadro");
		Vector3 pos = new Vector3 (-9.5f, 1.05f, 0);
		Destroy (obj);
		objn = (GameObject) Instantiate (yadrr, pos, Quaternion.identity);
		objn.name = "Yadro";
		objn.transform.parent = paren.transform;
		objn.GetComponent<DistanceJoint2D>().enabled = true;
		objn.GetComponent<DistanceJoint2D>().connectedBody = palk.GetComponent<Rigidbody2D>();
		objn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);
		objn.GetComponent<Rigidbody2D>().drag = 0f;
		objn.GetComponent<Yadro>().daged = false;
	}

	// Use this for initialization
	void Start () {
		print ("!");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
