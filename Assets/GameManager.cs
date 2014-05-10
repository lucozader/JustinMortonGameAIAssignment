using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {//setup start states for gameObjects
	    float time;
	// Use this for initialization
	void Start () {

		GameObject timeKeeper = GameObject.FindGameObjectWithTag("timer");
		GameObject deathstar = GameObject.FindGameObjectWithTag("death");
		GameObject bigship1 = GameObject.FindGameObjectWithTag("bigship1");
		GameObject bigship2 = GameObject.FindGameObjectWithTag("bigship2");
		GameObject bigship3 = GameObject.FindGameObjectWithTag("bigship3");
		GameObject vader = GameObject.FindGameObjectWithTag("vader");
		GameObject falcon = GameObject.FindGameObjectWithTag("falcon");
		GameObject [] enemies = GameObject.FindGameObjectsWithTag("enemy");//create an array of all tie fighters
		GameObject [] friends = GameObject.FindGameObjectsWithTag("friend");//create an array of all x wings



		bigship1.GetComponent<StateMachine>().SwicthState(new ArriveState1(bigship1,falcon,enemies));//set up initial states
		bigship2.GetComponent<StateMachine>().SwicthState(new ArriveState1(bigship2,falcon,enemies));
		bigship3.GetComponent<StateMachine>().SwicthState(new ArriveState1(bigship3,falcon,enemies));
		falcon.GetComponent<StateMachine>().SwicthState(new ArriveState1(falcon,falcon,enemies));
		vader.GetComponent<StateMachine>().SwicthState(new IdleState(vader));
	


		foreach(GameObject go in friends){//set up items quickly via array

			go.GetComponent<StateMachine>().SwicthState(new ArriveState1(go,falcon,enemies));
		}

	foreach(GameObject got in enemies){
			got.GetComponent<StateMachine>().SwicthState(new OffsetPursuit(got,vader,friends));//vader = leader//attack x wings = friends
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
