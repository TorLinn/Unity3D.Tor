using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour
{
	char c = ' ';
	WWW www;
	JSONObject jo;


	public void Save ()
	{
		print ("start insert");
		c = 'e';
		int pow = GameObject.Find ("Script").GetComponent<KubStvor> ().grany * GameObject.Find ("Script").GetComponent<KubStvor> ().grany;
		GameObject[] obj = new GameObject[pow];
		obj = GameObject.FindGameObjectsWithTag ("Kub");
		foreach (GameObject oB in obj) {
			WWWForm form = new WWWForm ();
			form.AddField ("x", oB.transform.position.x.ToString ());
			form.AddField ("y", oB.transform.position.y.ToString ());
			form.AddField ("z", oB.transform.position.z.ToString ());
			form.AddField ("rx", oB.transform.rotation.x.ToString ());
			form.AddField ("ry", oB.transform.rotation.y.ToString ());
			form.AddField ("rz", oB.transform.rotation.z.ToString ());
			form.AddField ("rw", oB.transform.rotation.w.ToString ());
			www = new WWW ("http://ucheba.zz.mu/save_coordinat.php", form);
		}


	}
	public void Load ()
	{
		print ("Load");
	}

	void Update ()
	{
		if (www != null && www.isDone) {
			print ("finish insert " + www.text);
			www = null;
		}
	}
}
