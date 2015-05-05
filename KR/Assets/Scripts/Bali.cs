using UnityEngine;
using System.Collections;

public class Bali : MonoBehaviour
{

	void OnTriggerEnter (Collider col)
	{
		Destroy (gameObject);
		col.GetComponent<Player> ().Bali ++;
	}

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
