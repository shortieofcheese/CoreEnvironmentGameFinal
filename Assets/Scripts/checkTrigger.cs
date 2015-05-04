using UnityEngine;
using System.Collections;

public class checkTrigger : MonoBehaviour {

	public int triggerID;
	public int desiredSceneId;

	MakeFade mf;
	bool triggered;

	// Use this for initialization
	void Start () {
		mf = GameObject.Find("_Game Manager").GetComponent<MakeFade>();	
	}

	void OnTriggerEnter (Collider obj){
		if (obj.gameObject.tag == "Player" && !triggered && StateManager.stateID == triggerID){
			StateManager.stateID++;
			mf.FadeInToScene(2.5f, desiredSceneId);
			triggered = true;
		}
	}

}
