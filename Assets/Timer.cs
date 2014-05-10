using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {//setup a handy timer

	public static float timer;//static so easy to access

	// Use this for initialization
	void Start () {
		 timer = 0.0f;
	
	}
	
	// Update is called once per frame
	void Update () {
		timer = timer+1*Time.deltaTime;
		Debug.Log(timer);
	
	}


}
