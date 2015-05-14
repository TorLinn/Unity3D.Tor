using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour
{
	char c = ' ';
	WWW www, ppp;
	JSONObject jo;
	Transform oo;


	public void Save ()
	{
		print ("start insert");
		www = new WWW ("http://site.local/ochistka.php");
		int pow = GameObject.Find ("Script").GetComponent<KubStvor> ().grany * GameObject.Find ("Script").GetComponent<KubStvor> ().grany;
		GameObject[] obj = new GameObject[pow];
		obj = GameObject.FindGameObjectsWithTag ("Kub");
		foreach (GameObject oB in obj) {
			WWWForm form = new WWWForm ();
			form.AddField ("name", oB.transform.name);
			form.AddField ("x", oB.transform.position.x.ToString ());
			form.AddField ("y", oB.transform.position.y.ToString ());
			form.AddField ("z", oB.transform.position.z.ToString ());
			form.AddField ("rx", oB.transform.rotation.x.ToString ());
			form.AddField ("ry", oB.transform.rotation.y.ToString ());
			form.AddField ("rz", oB.transform.rotation.z.ToString ());
			form.AddField ("rw", oB.transform.rotation.w.ToString ());
			www = new WWW ("http://site.local/save_coordinat.php", form);
		}


	}
	public void Load ()
	{
		print ("Load");
		ppp = new WWW ("http://site.local/load_coordinat.php");
	}

	void Update ()
	{
		if (www != null && www.isDone) {
			print ("finish insert " + www.text);
			www = null;
		}
		if (ppp != null && ppp.isDone) {
			int pow = GameObject.Find ("Script").GetComponent<KubStvor> ().grany * GameObject.Find ("Script").GetComponent<KubStvor> ().grany;
			GameObject[] obj = new GameObject[pow];
			obj = GameObject.FindGameObjectsWithTag ("Kub");
			print ("finish load " + ppp.text);
			jo = new JSONObject (ppp.text);
			foreach (var json in jo.list) {
				var data = json.ToDictionary ();
				oo = transform.Find (data ["name"]);

				oo.position = new Vector3 (float.Parse (data ["x"]),
					                              	float.Parse (data ["y"]),
					                              	float.Parse (data ["z"]));
				oo.rotation = new Quaternion (float.Parse (data ["rx"]),
				                                        float.Parse (data ["ry"]),
				             							float.Parse (data ["rz"]),
				             							float.Parse (data ["rw"]));
                
			}
			ppp = null;
		}
	}
}
