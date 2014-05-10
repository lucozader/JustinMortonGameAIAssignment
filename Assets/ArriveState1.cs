using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System;

class ArriveState1:State///arrive state
	/// The time shot.
	/// </summary>
{
	GameObject [] enemyGameObject;//an array of enemy game objects//remember different sides have different views of who is the enemy
	GameObject leader;//leader

	
	public override string Description()
	{
		return "Arrive State";
	}
	
	public ArriveState1(GameObject myGameObject, GameObject leader, GameObject [] enemyGameObject):base(myGameObject) //change
	{ 
		this.enemyGameObject = enemyGameObject;
		this.leader = leader;


	}
	
	public override void Enter()//change contents
	{
		myGameObject.GetComponent<SteeringBehaviours>().TurnOffAll();
		myGameObject.GetComponent<SteeringBehaviours>().ArriveEnabled = true;
		myGameObject.GetComponent<SteeringBehaviours>().arrivePos = new Vector3(0, 0, 0)+myGameObject.GetComponent<SteeringBehaviours>().arrivePos;


	}
	
	public override void Exit()
	{
		myGameObject.GetComponent<SteeringBehaviours>().TurnOffAll();            


	}
	
	public override void Update()
	{
		if(myGameObject.tag == "falcon" && Timer.timer > 16f){//after 15 seconds change the state from arrive to idle for the millenium falcon
			myGameObject.GetComponent<StateMachine>().SwicthState(new IdleState(myGameObject));
		}
		if(myGameObject.tag == "friend" && Timer.timer > 10f){//if the ship is an x wing change the state to offset pursuit, the leader is the millenium falcon
			myGameObject.GetComponent<StateMachine>().SwicthState(new OffsetPursuit(myGameObject, leader, enemyGameObject));
		}

		
	}
}
