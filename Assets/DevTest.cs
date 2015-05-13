using UnityEngine;
using System.Collections;

public class DevTest : MonoBehaviour {


	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown("1")){
			StateManager.stateID = 1;
			StateManager.objectsFound = 0;
		}

		if(Input.GetKeyDown("2")){
			StateManager.stateID = 2;
			StateManager.objectsFound = 0;
		}

		if(Input.GetKeyDown("3")){
			StateManager.stateID = 3;
			StateManager.objectsFound = 0;
		}


	}
}
