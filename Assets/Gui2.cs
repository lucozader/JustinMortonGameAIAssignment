using UnityEngine;
using System.Collections;

public class Gui2 : MonoBehaviour {//manage second gui, create, change and destroy

	public Texture2D test;
	public Texture2D test1;
	public Texture2D test2;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Timer.timer>128){
			gameObject.guiTexture.texture = test;
		}
		if(Timer.timer>131){
			gameObject.guiTexture.texture = test1;
		}
		if(Timer.timer>134){
			gameObject.guiTexture.texture = test2;
		}
		if(Timer.timer>137){
			Destroy (gameObject);
		}
	}
}

