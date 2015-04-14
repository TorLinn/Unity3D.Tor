using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Play : MonoBehaviour {
	
	public int Score = 0, HP = 100;
	public Text Scor, Hits;
	NavMeshAgent navAgent;

	// Use this for initialization
	void Start () {
		navAgent = gameObject.GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		Scor.text = " Score = " + Score;
		Hits.text = " HP = " + HP;

		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit, 200f)) {
				GetComponent<NavMeshAgent> ().SetDestination (hit.point);
			}
		}


		if (Mathf.Abs (Vector3.Distance (navAgent.velocity, new Vector3 (0, 0, 0))) < 0.1f) {
			GameObject[] coins = GameObject.FindGameObjectsWithTag ("Moneta");
			if (coins.Length > 0) {
				NavMeshPath path = new NavMeshPath ();
				Vector3 dest = coins [0].transform.position;
				NavMesh.CalculatePath (transform.position, coins [0].transform.position, NavMesh.AllAreas, path);
				float minPathLength = CalculateLength (path);
				
				foreach (var coin in coins) {
					NavMesh.CalculatePath (transform.position, coin.transform.position, NavMesh.AllAreas, path);
					float pathLength = CalculateLength (path);
					if (pathLength < minPathLength) {
						minPathLength = pathLength;
						dest = coin.transform.position;
					}
				}
				
				navAgent.SetDestination (dest);
			}
		}


	}

	float CalculateLength (NavMeshPath path)
	{
		float result = 0;
		
		for (int i = 0; i < path.corners.Length-1; i++) {
			result += Vector3.Distance (path.corners [i], path.corners [i + 1]);
		}
		
		return result;
	}
}
