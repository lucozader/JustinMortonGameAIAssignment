using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {// camera management class

	public Camera camera1;
	public Camera camera2;
	public Camera camera3;
	public Camera camera4;
	public Camera camera5;
	public Camera camera6;
	public Camera camera7;
	float timer = 0;
	bool once = false;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer = timer + 1*Time.deltaTime;
		if (Input.GetKeyDown("space")){
			once = true;
		}	
		if(once == true){//press space to lock camera in overhead view
			camera2.camera.enabled = true;
			camera1.camera.enabled = false;
		}
		if(once == false){//otherwise turn on one camera at a time, at specified times
			if(timer<5){
				camera1.enabled = true;
				camera2.enabled = false;
				camera3.enabled = false;
				camera4.enabled = false;
				camera5.enabled = false;
				camera6.enabled = false;
				camera7.enabled = false;


			}
			if(timer>5){
				camera1.enabled = false;
				camera2.enabled = true;
				camera3.enabled = false;
				camera4.enabled = false;
				camera5.enabled = false;
				camera6.enabled = false;
				camera7.enabled = false;


			}
			if(timer>20){
				camera1.enabled = false;
				camera2.enabled = false;
				camera3.enabled = true;
				camera4.enabled = false;
				camera5.enabled = false;
				camera6.enabled = false;
				camera7.enabled = false;


			}
			if(timer>26){
				camera1.enabled = false;
				camera2.enabled = true;
				camera3.enabled = false;
				camera4.enabled = false;
				camera5.enabled = false;
				camera6.enabled = false;
				camera7.enabled = false;


			}
			if(timer>70){//falcon
				camera1.enabled = false;
				camera2.enabled = false;
				camera3.enabled = false;
				camera4.enabled = false;
				camera5.enabled = true;
				camera6.enabled = false;
				camera7.enabled = false;


			}
			if(timer>80){//top
				camera1.enabled = false;
				camera2.enabled = true;
				camera3.enabled = false;
				camera4.enabled = false;
				camera5.enabled = false;
				camera6.enabled = false;
				camera7.enabled = false;


			}

			if(timer>115){//top
				camera1.enabled = false;
				camera2.enabled = false;
				camera3.enabled = false;
				camera4.enabled = false;
				camera5.enabled = false;
				camera6.enabled = true;
				camera7.enabled = false;

				
			}
			if(timer>120){//top
				camera1.enabled = false;
				camera2.enabled = false;
				camera3.enabled = false;
				camera4.enabled = false;
				camera5.enabled = false;
				camera6.enabled = false;
				camera7.enabled = true;
				
				
			}


		}


	}
}
