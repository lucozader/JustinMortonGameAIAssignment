using UnityEngine;
using System.Collections;

public class SoundEffects : MonoBehaviour {//manage sound effects
	public AudioClip wilhelm;
	bool wilhelm1 = true;
	public AudioClip planetBoom;
	bool planetBoom1 = true;
	public AudioClip fireLazer;
	public bool fireLazer1 = false;
	public AudioClip superLazer;
    bool superLazer1 = true;
	public AudioClip smallExplosion;
	public bool smallExplosion1 = false;
	public AudioClip kamikazeExplosion;
    bool kamikazeExplosion1 = true;
	public AudioClip justinScream;
	bool justinScream1 = true;
	public AudioClip commentary;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		if(Commentary.commentary==true){
			audio.PlayOneShot(commentary);
			Commentary.commentary = false;
		}

		if(Timer.timer> 112 && justinScream1 == true){
			audio.PlayOneShot(justinScream);
			justinScream1 = false;
		}

		if(Timer.timer> 111 && kamikazeExplosion1 == true){
			audio.PlayOneShot(kamikazeExplosion);
			kamikazeExplosion1 = false;
		}
		if(smallExplosion1 == true){
			audio.PlayOneShot(smallExplosion);
			smallExplosion1 = false;
		}

		if(fireLazer1 == true){
			audio.PlayOneShot(fireLazer);
			fireLazer1 = false;
		}

		if(Timer.timer>118&&superLazer1 == true){
			audio.PlayOneShot(superLazer);
			superLazer1 = false;
		}
		if(Timer.timer>123&&planetBoom1 == true){
			audio.PlayOneShot(planetBoom);
			planetBoom1 = false;
		}
		if(Timer.timer>134&&wilhelm1 == true){
			audio.PlayOneShot(wilhelm);
			wilhelm1 = false;
		}
	
	}
}
