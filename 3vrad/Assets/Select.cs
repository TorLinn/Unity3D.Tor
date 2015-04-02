using UnityEngine;
using System.Collections;

public class Select : MonoBehaviour {
	int x,y;
	int por = Genlev.grany;
	string nnam;

	void OnMouseDown () {
		Color col;
		print (gameObject.name);

		if ((x-1>=0) && (Genlev.obj [x-1,y].tag == "Selected")) {
			Genlev.obj [x-1,y].tag = "Igra";
			//iTween.MoveAdd (Genlev.obj [x-1,y], iTween.Hash("z",-1,"x",0.5,"easetype",iTween.EaseType.linear, "time", 0.1));
			//iTween.MoveAdd (Genlev.obj [x-1,y], iTween.Hash("z",1,"x",0.5,"easetype",iTween.EaseType.linear, "delay", 0.1, "time", 0.1));
			//iTween.MoveAdd (Genlev.obj [x,y], iTween.Hash("z",1,"x",-0.5,"easetype",iTween.EaseType.linear, "time", 0.1));
			//iTween.MoveAdd (Genlev.obj [x,y], iTween.Hash("z",-1,"x",-0.5,"easetype",iTween.EaseType.linear, "delay", 0.1, "time", 0.1));
			col = Genlev.obj [x,y].GetComponent<MeshRenderer>().material.color;
			Genlev.obj [x,y].GetComponent<MeshRenderer>().material.color = Genlev.obj [x-1,y].GetComponent<MeshRenderer>().material.color;
			Genlev.obj [x-1,y].GetComponent<MeshRenderer>().material.color = col;
			return;


		}
		if ((x+1<=por-1) && (Genlev.obj [x+1,y].tag == "Selected")) {
			Genlev.obj [x+1,y].tag = "Igra";
			col = Genlev.obj [x,y].GetComponent<MeshRenderer>().material.color;
			Genlev.obj [x,y].GetComponent<MeshRenderer>().material.color = Genlev.obj [x+1,y].GetComponent<MeshRenderer>().material.color;
			Genlev.obj [x+1,y].GetComponent<MeshRenderer>().material.color = col;
			return;
		}
		if ((y-1>=0) && (Genlev.obj [x,y-1].tag == "Selected")) {
			Genlev.obj [x,y-1].tag = "Igra";
			col = Genlev.obj [x,y].GetComponent<MeshRenderer>().material.color;
			Genlev.obj [x,y].GetComponent<MeshRenderer>().material.color = Genlev.obj [x,y-1].GetComponent<MeshRenderer>().material.color;
			Genlev.obj [x,y-1].GetComponent<MeshRenderer>().material.color = col;
			return;
		}
		if ((y+1<=por-1) && (Genlev.obj [x,y+1].tag == "Selected")) {
			Genlev.obj [x,y+1].tag = "Igra";
			col = Genlev.obj [x,y].GetComponent<MeshRenderer>().material.color;
			Genlev.obj [x,y].GetComponent<MeshRenderer>().material.color = Genlev.obj [x,y+1].GetComponent<MeshRenderer>().material.color;
			Genlev.obj [x,y+1].GetComponent<MeshRenderer>().material.color = col;
			return;
		}
		for (int i = 0; i < por; i++) {
			for (int j = 0; j < por; j++) {
				Genlev.obj [i,j].tag = "Igra";
			}
		}
		gameObject.tag = "Selected";	
}

	// Use this for initialization
	void Start () {
		nnam = gameObject.name;
		x = int.Parse (nnam.Substring (2, 2));
		y = int.Parse (nnam.Substring (5, 2));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
