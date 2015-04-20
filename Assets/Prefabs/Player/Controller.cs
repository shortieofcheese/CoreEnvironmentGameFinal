using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	GameObject normal, polaroid;
	bool switched;


	// Use this for initialization
	void Start () {

		normal = GameObject.Find("FirstPersonCharacter");
		polaroid = GameObject.Find("Polaroid");

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Space)){
			if (!switched) {
				normal.tag = "Untagged";
				polaroid.tag = "MainCamera";
				normal.GetComponent<Camera>().enabled = false;
				polaroid.GetComponent<Camera>().enabled = true;
				switched = !switched;
				
			} else {
				normal.tag = "MainCamera";
				polaroid.tag = "Untagged";
				polaroid.GetComponent<Camera>().enabled = false;
				normal.GetComponent<Camera>().enabled = true;
				switched = !switched;
				
			}

		}


	
	}
}
