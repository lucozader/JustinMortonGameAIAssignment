using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System;

public class PursueState:State{//pursue

		GameObject[] teasee;
		int i;
		GameObject leader;
		GameObject victim;
		
		
		public override string Description()
		{
			return "Tease State";
		}
		
		public PursueState(GameObject entity, GameObject []teasee,int i):base(entity)//additional stuff added to keep track of an array of enemies
		{
			this.teasee = teasee;
			this.i = i;
			if(myGameObject.tag == "friend"){ victim = GameObject.FindGameObjectWithTag("vader");}//set victim
			if(myGameObject.tag == "enemy"){ victim = GameObject.FindGameObjectWithTag("falcon");}
			if(myGameObject.tag == "enemy"){ leader = GameObject.FindGameObjectWithTag("vader");}//set leader
			if(myGameObject.tag == "friend"){leader = GameObject.FindGameObjectWithTag("falcon");}
			
			
		}
		
		public override void Enter()
		{
			myGameObject.GetComponent<SteeringBehaviours>().TurnOffAll();
			myGameObject.GetComponent<SteeringBehaviours>().PursuitEnabled = true;
			myGameObject.GetComponent<SteeringBehaviours>().pursueTarget = victim;//of opposition}

		}
		public override void Update()
		{

			if(Timer.timer>100){
				myGameObject.GetComponent<StateMachine>().SwicthState(new OffsetPursuit(myGameObject, leader,teasee));
				
			}
		float range = 5.0f;           
		// Can I see the enemy?
		if ((victim.transform.position - myGameObject.transform.position).magnitude < range)
		{
			// Is the leader inside my FOV
			myGameObject.GetComponent<StateMachine>().SwicthState(new AttackingState(myGameObject, teasee,0));
		}
		}
		
		public override void Exit()
		{
			myGameObject.GetComponent<SteeringBehaviours>().TurnOffAll();            
		}
	}
