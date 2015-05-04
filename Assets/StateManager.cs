using UnityEngine;
using System.Collections;

public class StateManager : MonoBehaviour {

	static public int stateID = 1;
	static public int objectsFound = 0;

	MakeFade mf;

	void Start(){
		mf = this.gameObject.GetComponent<MakeFade>();	
	}

	void Update(){
		if (objectsFound >= 3){
			StateManager.objectsFound = 0;
			mf.FadeInToScene(2f, 1);
		}
	}

}
