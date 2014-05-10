using UnityEngine;
using System.Collections;

public class TieTitleSound : MonoBehaviour {//play tie fighter noise
	public AudioClip tie;
	bool once;
	float time1;


	// Use this for initialization
	void Start () {
		once = false;
		time1 = 0;


	}
	
	// Update is called once per frame
	void Update () {

		time1 = time1 + 1*Time.deltaTime;
		if(time1>1 ){
			if(once == false){
				audio.PlayOneShot(tie);
				once = true;


			}
		}
	}
}
