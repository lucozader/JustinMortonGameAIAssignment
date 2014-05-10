using System;
using System.Collections.Generic;
using UnityEngine;

public class IdleState:State
{
    static Vector3 initialPos = Vector3.zero;

  

    public override string Description()
    {
        return "Idle State";
    }

    public IdleState(GameObject myGameObject)
        : base(myGameObject)
    {
    }

    public override void Enter()
	{           
	if(myGameObject.tag == "falcon"){//millenium falcon path
        myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Add(new Vector3(-30, 0, 0));
        myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Add(new Vector3(5, 0, 10));
        myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Add(new Vector3(20, 0, 15));
        myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Add(new Vector3(40, 0, 10));
		myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Add(new Vector3(70, 0, 0));
		myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Add(new Vector3(40, 0,-10));
		myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Add(new Vector3(20, 0, -15));
		myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Add(new Vector3(5, 0, -10));
	}

	if(myGameObject.tag == "vader"&&Timer.timer<100){//vader shuttle path
		myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Add(new Vector3(-40, 0, 0));
		myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Add(new Vector3(-45, 0, -15));
		myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Add(new Vector3(-70, 0, 0));
		myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Add(new Vector3(-45, 0, 15));

	}

	if(myGameObject.tag == "vader"&&Timer.timer>100){//vater shuttle kamikaze run
		myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Add(new Vector3(-38, 0, 0));
		myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Add(new Vector3(100, 0, 0));
		myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Add(new Vector3(200, 0, 0));
		myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Add(new Vector3(300, 0, 0));

			
	}

	if(myGameObject.tag == "followvader"){//not used
		myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Add(new Vector3(-40, 0, 0));
		myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Add(new Vector3(-45, 0, -15));
		myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Add(new Vector3(-70, 0, 0));
		myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Add(new Vector3(-45, 0, 15));
			
	}
        myGameObject.GetComponent<SteeringBehaviours>().path.Looped = true;            
        myGameObject.GetComponent<SteeringBehaviours>().path.draw = true;
        myGameObject.GetComponent<SteeringBehaviours>().TurnOffAll();
        myGameObject.GetComponent<SteeringBehaviours>().FollowPathEnabled = true;
    }

    public override void Exit()
    {
        myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Clear();
		myGameObject.GetComponent<SteeringBehaviours>().FollowPathEnabled = false;


    }

    public override void Update()
    {
		if(myGameObject.tag == "vader"&&Timer.timer  > 100f){
			myGameObject.GetComponent<StateMachine>().SwicthState(new IdleState(myGameObject));//new state with new path

		if(myGameObject.transform.position.x >0)
		{
			myGameObject.GetComponent<DestroyShip>().destroyShip=true;//remove vader from scene
			myGameObject.GetComponent<SteeringBehaviours>().TurnOffAll();
		

			}}

		//i don't want the millenium falcon or shuttle to attack so i blanked out the code below

       // float range = 5.0f;           
        // Can I see the enemy?
      //  if (((enemyGameObject[0].transform.position - myGameObject.transform.position).magnitude < range)&&myGameObject.tag != "falcon")
     //   {
            // Is the leader inside my FOV
          //  myGameObject.GetComponent<StateMachine>().SwicthState(new AttackingState(myGameObject, enemyGameObject));
       // }
    }
}
