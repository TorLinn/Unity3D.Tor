using UnityEngine;
using System.Collections;

public class SummMigCifr : MonoBehaviour {

	public int n,m;
	int summ = 0;

	// Use this for initialization
	void Start () {
	for (int i = n; i <= m; i++) {
			summ = summ+i;
		}
		print(summ);
	}

		// Update is called once per frame
	void Update () {
	
	}
}
