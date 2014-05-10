using UnityEngine;
using System.Collections;

public class GUI : MonoBehaviour {//test script to see how to change gui properties
	public Texture2D test;
	public Texture2D test1;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		renderer.material.mainTexture = test;


	}
}

