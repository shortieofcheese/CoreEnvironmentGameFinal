using UnityEngine;
using System.Collections;

public class soundPlay2 : MonoBehaviour {

	AudioSource audio;

	void Start () {
		audio = GetComponent<AudioSource>();
		
		if (StateManager.stateID == 2){
			audio.Play();
			
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
