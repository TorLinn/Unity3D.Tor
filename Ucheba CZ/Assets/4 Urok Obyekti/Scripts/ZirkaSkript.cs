using UnityEngine;
using System.Collections;

public class ZirkaSkript : MonoBehaviour {

	public Sprite [] spr;
	float timer;

	int i = Random.Range (0, 4);
	float j = Random.Range (-0.015f,0.016f), l = Random.Range (-0.015f,0.016f), k = Random.Range (-0.015f,0.016f);
	void OnMouseDown () {
		if (GetComponent<SpriteRenderer> ().sprite.name == "Zirka") {
			Obyekti.Count = Obyekti.Count + 3;
		} 
		else {
			Obyekti.Count = Obyekti.Count - 1;
		}
		Destroy(gameObject);
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		timer = timer + Time.deltaTime;

		gameObject.transform.position = gameObject.transform.position + new Vector3 (j,l,k);  

		if (timer >= 3) {
			GetComponent<SpriteRenderer> ().sprite = spr[i];
			GetComponent<SpriteRenderer> ().color = new Color (0f, 0f, 250f, 250f);

		}		
		if (timer >= 6) {
			GetComponent<SpriteRenderer> ().sprite = spr[i];
			GetComponent<SpriteRenderer> ().color = new Color (0f, 250f, 0f, 250f);
		}		
		if (timer >= 9) {
			GetComponent<SpriteRenderer> ().sprite = spr[i];
			GetComponent<SpriteRenderer> ().color = new Color (250f, 0f, 0f, 250f);
		}		
		if (timer >= 12) {
			GetComponent<SpriteRenderer> ().sprite = spr[i];
			GetComponent<SpriteRenderer> ().color = new Color (250f, 160f, 0f, 250f);
		}
		if (timer >= 15) {
			Destroy(gameObject);
		}

	}
}
