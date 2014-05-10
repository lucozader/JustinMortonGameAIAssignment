using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System;

class AttackingState:State//attacking state
{
    float timeShot = 0.25f;
    GameObject [] enemyGameObject ;//an array of enemy gameobjects
	GameObject leader;//the leader
	GameObject bigShip;//one of the big friendly ships
	GameObject target;//target
	int i;//keep track of enemy in the array


    public override string Description()
    {
        return "Attacking State";
    }

    public AttackingState(GameObject myGameObject, GameObject [] enemyGameObject,int i):base(myGameObject)
    {
        this.enemyGameObject = enemyGameObject;
		this.i = i;
		bigShip = GameObject.FindGameObjectWithTag("bigship2");
		target = GameObject.FindGameObjectWithTag("falcon");


    }

    public override void Enter()

	{  
		if(myGameObject.tag == "friend"){ leader = GameObject.FindGameObjectWithTag("falcon");}//follow millenium facon
		if(myGameObject.tag == "enemy"){ leader = GameObject.FindGameObjectWithTag("vader");}//follow vader shuttle
        myGameObject.GetComponent<SteeringBehaviours>().TurnOffAll();
        myGameObject.GetComponent<SteeringBehaviours>().OffsetPursuitEnabled = true;
       myGameObject.GetComponent<SteeringBehaviours>().offsetPursuitOffset = new Vector3(0, 0, 5);
		if(myGameObject.layer != 11){ //attack big ship only if layer = 11 otherwise attack enemy specified
			myGameObject.GetComponent<SteeringBehaviours>().offsetPursueTarget = enemyGameObject[i];
		}
		if(myGameObject.layer ==11){ 
			myGameObject.GetComponent<SteeringBehaviours>().offsetPursueTarget = bigShip;
		}
    }

    public override void Exit()
    {
		myGameObject.GetComponent<SteeringBehaviours>().TurnOffAll();            


    }

    public override void Update()
	{ 
        float range = 10.0f;
        timeShot += Time.deltaTime;
        float fov = Mathf.PI / 4.0f;
        // Can I see the enemy?
        if ((enemyGameObject[i].transform.position - myGameObject.transform.position).magnitude > range&&myGameObject.layer != 11)
        {
            myGameObject.GetComponent<StateMachine>().SwicthState(new OffsetPursuit(myGameObject,leader,enemyGameObject));
        }
		if ((enemyGameObject[i].transform.position - myGameObject.transform.position).magnitude < range&&myGameObject.layer != 11&&myGameObject.layer != 13)

        {
            float angle;
            Vector3 toEnemy = (enemyGameObject[i].transform.position - myGameObject.transform.position);
            toEnemy.Normalize();
            angle = (float) Math.Acos(Vector3.Dot(toEnemy, myGameObject.transform.forward));
            if (angle < fov)
            {
                if (timeShot > 3f)
                {
                    GameObject lazer = new GameObject();
					Vector3 victoria = new Vector3(5000f,5000f,5000f);
					lazer.transform.position = victoria;
                    lazer.AddComponent<Lazer>();
					lazer.GetComponent<Lazer>().enemyList = enemyGameObject;
					lazer.AddComponent<LineRenderer>();//lazer is a linerenderer
                    lazer.transform.position = myGameObject.transform.position;
                    lazer.transform.forward = myGameObject.transform.forward;
                    timeShot = 0.0f;
                }
            }
		}
		if (Timer.timer>40&&myGameObject.layer == 11)///switch ships in layer 11 to offset pursuit after 40 seconds
		{
			myGameObject.GetComponent<StateMachine>().SwicthState(new OffsetPursuit(myGameObject,leader,enemyGameObject));
		}
		if (Timer.timer<40&&myGameObject.layer == 11)///attack big convoy ship

		{
			Vector3 victor = new Vector3 (20f,0f,0f);//location of big convoy ship
			float angle;
			Vector3 toEnemy = (victor - myGameObject.transform.position);
			toEnemy.Normalize();
			angle = (float) Math.Acos(Vector3.Dot(toEnemy, myGameObject.transform.forward));
			if (angle < fov)
			{
				if (timeShot > 2f)
				{
					GameObject lazer = new GameObject();
					lazer.AddComponent<Lazer>();
					lazer.GetComponent<Lazer>().enemyList = enemyGameObject;
					lazer.AddComponent<LineRenderer>();
					lazer.transform.position = myGameObject.transform.position;
					lazer.transform.forward = myGameObject.transform.forward;
					timeShot = 0.0f;
				}
			}


	}
		if (Timer.timer<100&&myGameObject.layer == 13)///wave to attack millenium falcon 
			
		{

			float angle;
			Vector3 toEnemy = (target.transform.position - myGameObject.transform.position);
			toEnemy.Normalize();
			angle = (float) Math.Acos(Vector3.Dot(toEnemy, myGameObject.transform.forward));
			if (angle < fov)
			{
				if (timeShot > 2f)
				{
					GameObject lazer = new GameObject();
					lazer.AddComponent<Lazer>();
					lazer.GetComponent<Lazer>().enemyList = enemyGameObject;
					lazer.AddComponent<LineRenderer>();
					lazer.transform.position = myGameObject.transform.position;
					lazer.transform.forward = myGameObject.transform.forward;
					timeShot = 0.0f;
				}
			}
			
			
		}
	}
}
