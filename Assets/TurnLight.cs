using UnityEngine;
using System.Collections;

public class TurnLight : MonoBehaviour {

	public Light desklight;
	bool lightOn;

	void OnLook(){

		if (Input.GetMouseButtonDown(0)){
			if (lightOn){

				desklight.enabled = false;
				lightOn = false;
			}else if (!lightOn){
				desklight.enabled = true;
				lightOn = true;
			}
		}

	}



}
