using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

class Lazer:MonoBehaviour//script to create and handle lazer sounds and collisions
{
	public GameObject [] enemyList;
	public GameObject prox;
	bool once = false;

	public void Start(){
		prox = GameObject.FindGameObjectWithTag("audio");
	}


    public void Update()
    {
        float speed = 5.0f;
        float width = 500;
        float height = 500;
	if(once ==  false){
			prox.GetComponent<SoundEffects>().fireLazer1 = true;
			once = true;}

        if ((transform.position.x < -(width / 2)) || (transform.position.x > width / 2) || (transform.position.z < -(height / 2)) || (transform.position.z > height / 2) || (transform.position.y < 0) || (transform.position.y > 100))
        {
            Destroy(gameObject);
        }
        transform.position += transform.forward * speed;
       // Debug.DrawLine(transform.position, transform.position + transform.forward * 10.0f, Color.red);
		LineRenderer pro = gameObject.GetComponent<LineRenderer>();
		Vector3 victor = transform.position;
		Vector3 victor1 = transform.position + transform.forward * 10.0f;
		
		pro.SetPosition(0,victor);//positions of lazer beam
		pro.SetPosition(1,victor1);
		pro.SetWidth(0.2f, 0.2f);
		
		pro.material.color = Color.green;

		//code if collides with enemy ship
		foreach(GameObject go in enemyList){///for every enemy in array//check if close//if close destroy
			if(go.GetComponent<DestroyShip>().destroyShip != null){
			if((go.transform.position - victor1).magnitude < 10)
			{ 

				prox.GetComponent<SoundEffects>().smallExplosion1 = true;//play explosion sound
				go.GetComponent<DestroyShip>().destroyShip = true;//remove ship from screen
				Destroy (gameObject);//destroy lazer beam

			}
		}
	}

    }
}
