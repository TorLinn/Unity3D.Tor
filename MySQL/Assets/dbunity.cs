using UnityEngine;
using System.Collections;

public class dbunity : MonoBehaviour
{
	char c = ' ';
	WWW www;
	JSONObject jo;
    
	void Update ()
	{
		if (Input.GetKeyDown ("e")) {
			print ("start insert");
			c = 'e';
			WWWForm form = new WWWForm ();
			form.AddField ("name", "player");
			form.AddField ("level", 1);
			form.AddField ("score", 10);
			www = new WWW ("http://site.local/setuser.php", form);
		}
		if (Input.GetKeyDown ("r")) {
			print ("start select");
			c = 'r';
			www = new WWW ("http://site.local/getuser.php");
		}
        
		if (www != null && www.isDone && c == 'e') {
			print ("finish insert " + www.text);
			www = null;
		} else if (www != null && www.isDone && c == 'r') {
			print ("finish select ");
			if (www.error == null) {
				jo = new JSONObject (www.text);
				foreach (var json in jo.list) {
					var data = json.ToDictionary ();
					print (data ["name"] + " " + data ["level"] + " " + data ["score"]);
				}
			}
			www = null;
		}
	}
}
