using UnityEngine;
using System.Collections;

public class GenericRotateScript : MonoBehaviour {///quickly set up rotation through editor

	public float xRotation = 0f;
	public float yRotation = 20f;
	public float zRotation = 0f;
	

	// Update is called once per frame
	void Update () {

		transform.Rotate(xRotation*Time.deltaTime,yRotation*Time.deltaTime,zRotation*Time.deltaTime);


	}
}
