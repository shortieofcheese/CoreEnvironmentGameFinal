using UnityEngine;
using System.Collections;

public class soundPlay : MonoBehaviour {

 AudioSource audio;


	void Start () {
		audio = GetComponent<AudioSource>();

		if (StateManager.stateID == 1){
			audio.Play();
			
		}

	}
}
	
	