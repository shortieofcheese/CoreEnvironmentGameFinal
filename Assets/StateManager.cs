using UnityEngine;
using System.Collections;

public class StateManager : MonoBehaviour {

	static public int stateID = 1;
	static public int objectsFound = 0;
	bool done;
	AudioSource audio;

	public doorAnimation door;

	MakeFade mf;

	void Start(){
		audio = GetComponent<AudioSource>();
		mf = this.gameObject.GetComponent<MakeFade>();	
	}

	void Update(){

		if (objectsFound >= 3 && stateID == 3){
			door.enabled = true;

			if (door.isOpen && !done){
				done = true;
				audio.Play();
				StateManager.objectsFound = 0;
				mf.FadeInToScene(1.5f, 2);

			}


		} else if (objectsFound >= 3){
			StateManager.objectsFound = 0;
			mf.FadeInToScene(2f, 2);
		}
	}

}
