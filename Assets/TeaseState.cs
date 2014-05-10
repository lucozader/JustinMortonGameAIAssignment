using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class TeaseState:State
{
    GameObject[] teasee;
	int i;
	GameObject leader;
	GameObject victim;


    public override string Description()
    {
        return "Tease State";
    }

    public TeaseState(GameObject entity, GameObject []teasee,int i):base(entity)
    {
        this.teasee = teasee;
		this.i = i;
		if(myGameObject.tag == "friend"){ leader = GameObject.FindGameObjectWithTag("falcon");}
		if(myGameObject.tag == "enemy"){ leader = GameObject.FindGameObjectWithTag("vader");}
		if(myGameObject.tag == "friend"){ victim = GameObject.FindGameObjectWithTag("vader");}
		if(myGameObject.tag == "enemy"){ victim = GameObject.FindGameObjectWithTag("falcon");}


    }

    public override void Enter()
    {
        myGameObject.GetComponent<SteeringBehaviours>().TurnOffAll();
        myGameObject.GetComponent<SteeringBehaviours>().PursuitEnabled = true;
		if(myGameObject.tag == "enemy"){
			myGameObject.GetComponent<SteeringBehaviours>().pursueTarget = victim;//of opposition}
    }
		if(myGameObject.tag == "friend"){
			myGameObject.GetComponent<SteeringBehaviours>().pursueTarget = teasee[0];//of opposition}
		}
	}
    public override void Update()
    {
        float distance = 5.0f;
        if (Vector3.Distance(myGameObject.transform.position, teasee[i].transform.position) < distance&&Timer.timer<80)
        {
            myGameObject.GetComponent<StateMachine>().SwicthState(new EvadeState(myGameObject, teasee,i));
        }
		if(Timer.timer>70){
			myGameObject.GetComponent<StateMachine>().SwicthState(new OffsetPursuit(myGameObject, leader,teasee));//tease millenium falcon at this time

		}
    }

    public override void Exit()
	{ 
       	myGameObject.GetComponent<SteeringBehaviours>().TurnOffAll();            
    }
}

