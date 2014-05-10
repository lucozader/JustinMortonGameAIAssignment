using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {//play music

	public AudioClip music;
	bool once = false;


	// Use this for initialization
	void Start () {
		if(once == false){
			audio.PlayOneShot(music);//play music once
			once = true;
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
