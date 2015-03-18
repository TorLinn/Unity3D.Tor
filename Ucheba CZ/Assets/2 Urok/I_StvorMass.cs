using UnityEngine;
using System.Collections;

public class I_StvorMass : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string s;
		int dlina1 = Random.Range (1,10);
		int dlina2 = Random.Range (1,10);

		//Одновимірний масив
		int[] mas1 = new int[dlina1]; 
		s = "";
		for (int i = 0; i < dlina1; i++) {
			mas1[i] = Random.Range(1,10);
			s = s + mas1[i]+" ";
		}	
		print ("одновимірний масив : \n "+s);

		//двовимірний масів
		int[,] mas2 = new int[dlina1, dlina2];
		s = "";
		for (int i = 0; i < dlina1; i++) {
			for (int j = 0; j < dlina2; j++) {
				mas2[i,j] = Random.Range(1,10);
				s = s+mas2[i,j]+" ";
			}
			s = s + "\n";
		}
		print ("двовимірний масив : \n"+s);

		//рваний масив
		int[][] mas3 = new int[dlina1][];
		s = "";
		for (int i = 0; i < mas3.Length; i++) {
			int dlina3 = Random.Range(1,10);
			mas3[i] = new int[dlina3];
			for (int j = 0; j < mas3[i].Length; j++) {
				mas3[i][j] = Random.Range(1,10);
				s = s+mas3[i][j]+" ";
			}
			s = s + "\n";
		}
		print ("рваний масив : \n"+s);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
