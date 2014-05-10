using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System;

class OffsetPursuit:State/// offset pursuit
	/// The time shot.
	/// </summary>
{
	float timeShot = 0.25f;
	GameObject followGameObject;
	GameObject [] enemyGameObject;

	
	public override string Description()
	{
		return "Offset Pursuit";
	}
	
	public OffsetPursuit(GameObject myGameObject, GameObject followGameObject,GameObject [] enemyGameObject):base(myGameObject) //change
	{
		this.followGameObject = followGameObject;
		this.enemyGameObject = enemyGameObject;

	}
	
	public override void Enter()//change contents
	{
		myGameObject.GetComponent<SteeringBehaviours>().TurnOffAll();
		myGameObject.GetComponent<SteeringBehaviours>().OffsetPursuitEnabled = true;
		myGameObject.GetComponent<SteeringBehaviours>().offsetPursueTarget = followGameObject;
	
	}
	
	public override void Exit()
	{
		if(myGameObject.GetComponent<DestroyShip>().destroyShip==true){//destroy ship if hit by lazer and if is in this state
		myGameObject.GetComponent<SteeringBehaviours>().TurnOffAll();	
		}
	}
	
	public override void Update()
	{
		
		float range = 10.0f;           
        // Can I see the enemy?
		for(int i = 0; i< enemyGameObject.Length; i++){//this bit here for x wings
        if (((enemyGameObject[i].transform.position - myGameObject.transform.position).magnitude < range)&&myGameObject.layer == 8)//brave
        {
            // Is the leader inside my FOV
            myGameObject.GetComponent<StateMachine>().SwicthState(new AttackingState(myGameObject, enemyGameObject,i));
        }
		if (((enemyGameObject[i].transform.position - myGameObject.transform.position).magnitude < range*2)&&myGameObject.layer == 9)//coward
		{
				// Is the leader inside my FOV
			myGameObject.GetComponent<StateMachine>().SwicthState(new EvadeState(myGameObject, enemyGameObject,i));
		}
				
	}
		if (Timer.timer > 30 &&myGameObject.layer == 11&&Timer.timer<40)//bigshipattackers//set up different waves of tie fighter attacks
		{
			// Is the leader inside my FOV
			myGameObject.GetComponent<StateMachine>().SwicthState(new AttackingState(myGameObject, enemyGameObject,0));//pursue and attack big ship//convoy ship at centre//method one
		}

		if (Timer.timer > 50 &&myGameObject.layer == 12&&Timer.timer<70)//teasers
		{
			// Is the leader inside my FOV
			myGameObject.GetComponent<StateMachine>().SwicthState(new TeaseState(myGameObject, enemyGameObject,0));//tease millenium falcon
		}
		if (Timer.timer > 80 &&myGameObject.layer == 13&&Timer.timer<100)//attack 
		{
			// Is the leader inside my FOV
			myGameObject.GetComponent<StateMachine>().SwicthState(new PursueState(myGameObject, enemyGameObject,0));//pursue and attack millenium falcon//method 2// note method one = method 2
		}
		if (Timer.timer > 100 &&myGameObject.layer == 10&&Timer.timer<120)//attack
		{
			// Is the leader inside my FOV
			//myGameObject.GetComponent<StateMachine>().SwicthState(new KamikazeState(myGameObject));
		}
	

	}
}
