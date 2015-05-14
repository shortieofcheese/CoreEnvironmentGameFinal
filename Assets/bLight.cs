using UnityEngine;
using System.Collections;

public class bLight : MonoBehaviour {
	
	AudioSource audio;
	
	bool lightOn;
	
	void Start () {
		audio = GetComponent<AudioSource>();

	}
	
	void Update () {

	}
	void OnLook(){
		
		if (Input.GetMouseButtonDown(0)){
	
				audio.Play();

			}
		}
		

	
}
