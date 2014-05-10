using UnityEngine;
using System.Collections;

public class AungierStreet : MonoBehaviour {//class to instantiate 3d text "the battle of aungier street"

	float timer;
	public GameObject pro;
	bool once = false;


	// Use this for initialization
	void Start () {
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timer = timer+ Time.deltaTime;
		if(timer > 5&& once == false){
			Vector3 victor = new Vector3(-5.53f,2.23f,46.37f);
			pro = Instantiate(pro,victor,Quaternion.identity ) as GameObject;
			once = true;


		}
	}
}
