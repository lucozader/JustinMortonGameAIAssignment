using UnityEngine;
using System.Collections;

public class KillTect : MonoBehaviour {//destroy text after 5 seconds

	float timer = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer = timer+Time.deltaTime;
		if(timer >5){
			Destroy (gameObject);

		}
	
	}
}
