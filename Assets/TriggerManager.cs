using UnityEngine;
using System.Collections;

public class TriggerManager : MonoBehaviour {

	public Transform player;
	public Transform trigger1, trigger2;

	void Start(){

		if (StateManager.stateID == 2){
			player.transform.position = trigger1.position;
		}
		if (StateManager.stateID >= 3){
			player.transform.position = trigger2.position;
		}



	}



}
