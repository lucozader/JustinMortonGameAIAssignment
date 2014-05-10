using UnityEngine;
using System.Collections;

public class DestroyPlanet : MonoBehaviour {//remove planet and instantiate explosion in it's place

	public GameObject explosion;
	bool once = false;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Timer.timer>123&&once == false){

			GameObject pro = Instantiate(explosion,transform.position,Quaternion.identity) as GameObject;//instantiate explosion
			once = true;
			gameObject.transform.Translate(5000f,5000f,5000f);//remove planet from visible area
		}
	
	}
}
