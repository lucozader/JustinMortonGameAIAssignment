using UnityEngine;
using System.Collections;

public class Quit : MonoBehaviour {//manage quit button and logic
	
	public AudioClip quitSound;

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
		audio.PlayOneShot(quitSound);
		Application.Quit();
		
		
		
	}
}
