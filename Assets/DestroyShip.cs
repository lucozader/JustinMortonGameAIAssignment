using UnityEngine;
using System.Collections;

public class DestroyShip : MonoBehaviour {//remove ship from screen and instantiate explosion in it's place

	public bool destroyShip = false;
	public GameObject explosion;
	bool once = false;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(destroyShip == true){
			if(once == false){
				GameObject pro = Instantiate(explosion,transform.position,Quaternion.identity) as GameObject;
				once = true;
			}
			gameObject.transform.Translate(10000f,10000f,10000f);
		}
	}
}
