using UnityEngine;
using System.Collections;

public class BoxHP : MonoBehaviour
{

	public GameObject kott;
	public Texture ba;

	void OnGUI ()
	{
		Vector3 pos = Camera.main.WorldToScreenPoint (kott.transform.position);
		float hp = Ruh.pat.HP;
		if (hp < 0) {
			hp = 0;
		}
		GUI.DrawTexture (new Rect (pos.x - 25, pos.y + 60, 50 * hp / 100, 3), ba);
	}
}
