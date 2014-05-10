using UnityEngine;
using System.Collections;

public class Line : MonoBehaviour {//script to test how linerenderer works

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		LineRenderer pro = gameObject.GetComponent<LineRenderer>();
		Vector3 victor = new Vector3(10f,10f,10f);
		Vector3 victor1 = new Vector3(5f,5f,5f);
		pro.SetPosition(0,victor1);
		pro.SetPosition(1,victor);
	}
}
