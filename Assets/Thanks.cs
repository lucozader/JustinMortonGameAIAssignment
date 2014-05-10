using UnityEngine;
using System.Collections;

public class Thanks : MonoBehaviour {//load thank you scene

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Timer.timer>140){
			Application.LoadLevel("end");
		}
	
	}
}
