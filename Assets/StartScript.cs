using UnityEngine;
using System.Collections;

public class StartScript : MonoBehaviour {

	public AudioClip startSound;
	void OnMouseEnter()
	{
		renderer.material.color = Color.red;
		//Debug.Log("MOUSE ENTERED");
	}
	
	void OnMouseExit()
	{
		renderer.material.color = Color.yellow;
		
	}
	
	void OnMouseUp()
	{
		audio.PlayOneShot(startSound);
		Application.LoadLevel("scene1");
		
		
		
	}
}
