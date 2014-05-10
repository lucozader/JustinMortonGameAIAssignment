using UnityEngine;
using System.Collections;

public class GenericShipMove : MonoBehaviour {//move ship about, through editor, quickly
	public float xPos = 30f;
	public float yPos = 5f;
	public float zPos = 200f;
	public float speed = 20.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 dest = new Vector3(xPos, yPos, zPos);
		Vector3 toDest = dest - transform.position;
		if (toDest.magnitude > 0.1f)
		{
			toDest.Normalize();

			transform.position += toDest * speed * Time.deltaTime;
			//transform.forward = toDest;
		}
		
	}
}