using UnityEngine;
using System.Collections;

public class ObjectsManager : MonoBehaviour {

	public GameObject
		state1Object1, state1Object2, state1Object3,
		state2Object1, state2Object2, state2Object3,
		state3Object1, state3Object2, state3Object3;

	// Update is called once per frame
	void Update () {
	
		if (StateManager.stateID == 1){
			state1Object1.SetActive(true);
			state1Object2.SetActive(true);
			state1Object3.SetActive(true);
		} else {
			state1Object1.SetActive(false);
			state1Object2.SetActive(false);
			state1Object3.SetActive(false);
		}

		if (StateManager.stateID == 2){
			state2Object1.SetActive(true);
			state2Object2.SetActive(true);
			state2Object3.SetActive(true);
		} else {
			state2Object1.SetActive(false);
			state2Object2.SetActive(false);
			state2Object3.SetActive(false);
		}

		if (StateManager.stateID == 3){
			state3Object1.SetActive(true);
			state3Object2.SetActive(true);
			state3Object3.SetActive(true);
		} else {
			state3Object1.SetActive(false);
			state3Object2.SetActive(false);
			state3Object3.SetActive(false);
		}

	}
}
