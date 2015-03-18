using UnityEngine;
using System.Collections;

public class Misyaci : MonoBehaviour {

	int vint, mis;
	
	// Use this for initialization
	void Start () 
	{
		vint = Random.Range (5,12);
		print ("vint = "+vint);
		for (int i = 0; i < vint; i++) {
			mis = Random.Range (1,13);
			switch (mis) 
			{
			case 1:
				print("січень");
				break;
			case 2:
				print("лютий");
				break;
			case 3:
				print("березень");
				break;
			case 4:
				print("квітень");
				break;
			case 5:
				print("травень");
				break;
			case 6:
				print("червень");
				break;
			case 7:
				print("липень");
			break;			
			case 8:
				print("серпень");
				break;
			case 9:
				print("вересень");
				break;
			case 10:
				print("жовтень");
				break;
			case 11:
				print("листопад");
				break;
			case 12:
				print("грудень");
				break;
			default: 
				print ("невідомо");
				break;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
