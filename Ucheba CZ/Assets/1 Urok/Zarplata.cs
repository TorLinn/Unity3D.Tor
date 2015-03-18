using UnityEngine;
using System.Collections;

public class Zarplata : MonoBehaviour {
	public int zp;
	int kilk, kup = 64;

	// Use this for initialization
	void Start () {
		while (zp != 0) {
			kilk = zp/kup;
			if (kilk != 0) {
				print ("купюра  "+kup+"  "+kilk+"  шт");
			}
			zp = zp - (kup*kilk);
			kup = kup/2;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
