using System;
using System.Collections.Generic;
using UnityEngine;

public class KamikazeState:State//experimental state not used
{
	static Vector3 initialPos = Vector3.zero;
	
	
	
	public override string Description()
	{
		return "Kamikaze State";
	}
	
	public KamikazeState(GameObject myGameObject)
		: base(myGameObject)
	{
	}
	
	public override void Enter()
	{           
	

			

	
		myGameObject.GetComponent<SteeringBehaviours>().TurnOffAll();
	
	}
	public override void Exit()
	{
	}
	
	public override void Update()

	{
	float xPos = 38f;
	float yPos = 0f;
	float zPos = 0f;
	float speed = 8.0f;
		Vector3 dest = new Vector3(xPos, yPos, zPos);
		Vector3 toDest = dest - myGameObject.transform.position;
		if (toDest.magnitude > 0.1f)
		{
			toDest.Normalize();
			
			myGameObject.transform.position += toDest * speed * Time.deltaTime;
			//myGameObject.transform.forward = toDest;
		if(myGameObject.transform.position.x >-38)
		{
		myGameObject.GetComponent<DestroyShip>().destroyShip=true;
		//myGameObject.GetComponent<SteeringBehaviours>().TurnOffAll();
		}
	}
		}}
