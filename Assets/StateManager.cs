using UnityEngine;
using System.Collections;

public class StateManager : MonoBehaviour {

	static public int stateID = 1;
	static public int objectsFound = 0;
	bool done;
	AudioSource audio;

	public doorAnimation door;
	public GameObject player;
	public GameObject cinematicCamera;
	bool cinematicEnd;

	MakeFade mf;

	void Start(){
		audio = GetComponent<AudioSource>();
		mf = this.gameObject.GetComponent<MakeFade>();	
	}

	void Update(){

		if (objectsFound >= 3 && stateID == 3){
			door.enabled = true;
			if (!cinematicEnd){
				cinematicEnd = true;
				cinematicCamera.SetActive(true);
				player.SetActive(false);
				StartCoroutine(makePlayer());
			}

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

	IEnumerator makePlayer(){
		yield return new WaitForSeconds(5f);
		Debug.Log ("stuff");
		player.SetActive(true);
		cinematicCamera.SetActive(false);
	}

}
