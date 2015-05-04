using UnityEngine;
using System.Collections;

public class StateManager : MonoBehaviour {

	static public int stateID = 1;
	static public int objectsFound = 0;
	bool done;

	public doorAnimation door;

	MakeFade mf;

	void Start(){
		mf = this.gameObject.GetComponent<MakeFade>();	
	}

	void Update(){

		if (objectsFound >= 3 && stateID == 3){
			door.enabled = true;
			if (door.isOpen && !done){
				done = true;
				StateManager.objectsFound = 0;
				mf.FadeInToScene(1.5f, 1);

			}


		} else if (objectsFound >= 3){
			StateManager.objectsFound = 0;
			mf.FadeInToScene(2f, 1);
		}
	}

}
