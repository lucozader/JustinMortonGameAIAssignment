using UnityEngine;
using System.Collections;

public class EXplosionJustin : MonoBehaviour {//enlarge object over time for explosion

	int a = 1;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		a = a + 1;
		transform.localScale = new Vector3(a, a, a);//enlarge sphere that this is attached to for explosion	
	}
}
