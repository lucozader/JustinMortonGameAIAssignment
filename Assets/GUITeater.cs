using UnityEngine;
using System.Collections;

public class GUITeater : MonoBehaviour {//display gui, change it's texture, then destroy
	public Texture2D test;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Timer.timer>112){
			gameObject.guiTexture.texture = test;
		}
	if(Timer.timer>115){Destroy (gameObject);}
	}
}
