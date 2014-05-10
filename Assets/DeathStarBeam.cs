using UnityEngine;
using System.Collections;

public class DeathStarBeam : MonoBehaviour {//display a lazer beam drom the deathstar at specified time for specified duration
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		LineRenderer pro = gameObject.GetComponent<LineRenderer>();
		GameObject pro1 =  GameObject.FindGameObjectWithTag("deathstar1");//used editor objects to lay out the beam path
		GameObject pro2 =  GameObject.FindGameObjectWithTag("deathstar2");
		GameObject pro3 =  GameObject.FindGameObjectWithTag("deathstar3");
		GameObject pro4 =  GameObject.FindGameObjectWithTag("deathstar4");
		GameObject pro5 =  GameObject.FindGameObjectWithTag("deathstar5");
		GameObject pro6 =  GameObject.FindGameObjectWithTag("deathstar0");
		if(Timer.timer>118&&Timer.timer<128){
			pro.SetPosition(0,pro1.transform.position);//draw the beam
			pro.SetPosition(1,pro6.transform.position);
			pro.SetPosition(2,pro2.transform.position);
			pro.SetPosition(3,pro6.transform.position);
			pro.SetPosition(4,pro3.transform.position);
			pro.SetPosition(5,pro6.transform.position);
			pro.SetPosition(6,pro4.transform.position);
			pro.SetPosition(7,pro6.transform.position);
			pro.SetPosition(8,pro5.transform.position);
		}
			if(Timer.timer>128){
				Vector3 victor = new Vector3(5000f,5000f,5000f);//get rid of beam
				pro.SetPosition(0,victor);
				pro.SetPosition(1,victor);
				pro.SetPosition(2,victor);
				pro.SetPosition(3,victor);
				pro.SetPosition(4,victor);
				pro.SetPosition(5,victor);
				pro.SetPosition(6,victor);
				pro.SetPosition(7,victor);
				pro.SetPosition(8,victor);
		}

		pro.SetWidth(1f, 1f);//set beam parameters
		pro.material.color = Color.green;


		}

}
