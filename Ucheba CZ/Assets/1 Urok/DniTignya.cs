using UnityEngine;
using System.Collections;

public class DniTignya : MonoBehaviour {
	int vint, day;

	// Use this for initialization
	void Start () 
	{
		vint = Random.Range (1,1000);
		print (vint);
		day = vint % 7;
		print (day);
		switch (day) 
		{
			case 1:
				print("понеділок");
				break;
			case 2:
				print("вівторок");
				break;
			case 3:
				print("середа");
				break;
			case 4:
				print("четвер");
				break;
			case 5:
				print("п'ятниця");
				break;
			case 6:
				print("субота");
				break;
			case 0:
				print("неділя");
				break;
			default: 
				print ("невідомо");
				break;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
