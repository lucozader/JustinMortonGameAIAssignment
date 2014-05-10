using UnityEngine;
using System.Collections;

public class GuiController : MonoBehaviour {//instantiate GUi's at the right times
	public GameObject pro;
	public GameObject pro1;
	bool once = false;
	bool once2 = false;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(Timer.timer>109f&& once == false){
			Vector3 victor = new Vector3(0.8f,0.2f,0f);
			pro = Instantiate(pro,victor, Quaternion.identity)as GameObject;
			once = true;
		}
		if(Timer.timer>128f&& once2 == false){
			Vector3 victor1 = new Vector3(0.1f,0.4f,0f);
			pro = Instantiate(pro1,victor1, Quaternion.identity)as GameObject;
			once2 = true;
		}	
	
	}
}
