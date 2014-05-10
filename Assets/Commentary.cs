using UnityEngine;
using System.Collections;

public class Commentary : MonoBehaviour {//class to control commentary selection and playing

	public static bool commentary = false;///if true play commentary
	public bool on = false;
	public bool oneshot = false;
	public AudioClip commentarySound;

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
		oneshot = false;
		if(on == true&&oneshot == false){
			audio.PlayOneShot(commentarySound);
			commentary = false;
			GetComponent<TextMesh>().text = "Commentary Off";
			on = false;
			oneshot = true;
		}
		if(on == false&&oneshot == false){
			audio.PlayOneShot(commentarySound);
			commentary = true;
			GetComponent<TextMesh>().text = "Commentary On";
			on = true;
			oneshot = true;
		}

		
	}
}