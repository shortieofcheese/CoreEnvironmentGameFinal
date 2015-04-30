using UnityEngine;
using System.Collections;

public class checkTrigger : MonoBehaviour {

	MakeFade mf;
	bool triggered;

	// Use this for initialization
	void Start () {
		mf = GameObject.Find("_Game Manager").GetComponent<MakeFade>();	
	}

	void OnTriggerEnter (Collider obj){
		if (obj.gameObject.tag == "Player" && !triggered){
			mf.FadeInToScene(2.5f, 1);
			triggered = true;
		}
	}

}
