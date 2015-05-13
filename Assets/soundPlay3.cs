using UnityEngine;
using System.Collections;

public class soundPlay3 : MonoBehaviour {

	AudioSource audio;

	void Start () {

		audio = GetComponent<AudioSource>();
		
		if (StateManager.stateID == 3){
			audio.Play();
			
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
