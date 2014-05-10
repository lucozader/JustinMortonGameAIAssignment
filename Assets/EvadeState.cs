using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

class EvadeState:State//evade state
{
    GameObject [] teasee;
	int i;
    public override string Description()
    {
        return "Evade State";
    }

    public EvadeState(GameObject entity, GameObject[] teasee,int i):base(entity)
    {
        this.teasee = teasee;
		this.i = i;

    }

    public override void Enter()
    {
        myGameObject.GetComponent<SteeringBehaviours>().TurnOffAll();
        myGameObject.GetComponent<SteeringBehaviours>().EvadeEnabled = true;
        myGameObject.GetComponent<SteeringBehaviours>().evadeTarget = teasee[i];
    }

    public override void Update()
    {
        if (Vector3.Distance(myGameObject.transform.position, teasee[i].transform.position) > 30)
        {
            myGameObject.GetComponent<StateMachine>().SwicthState(new TeaseState(myGameObject, teasee,i));
        }
    }

    public override void Exit()
    {
        myGameObject.GetComponent<SteeringBehaviours>().TurnOffAll();            
    }
}
