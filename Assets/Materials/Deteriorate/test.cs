using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	public Material material1;
	public Material material2;
	public Material material3;
	public Material material4;

	Renderer renderer;


	static public int state;
	public int stateController;
	public bool controller;

	// Use this for initialization
	void Start () {

		renderer = GetComponent<Renderer>();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (controller) {
			state = stateController;
		}


		if (StateManager.stateID == 0) {
			renderer.material = material1;
		}
		if (StateManager.stateID == 1) {
			renderer.material = material2;
		}

		if (StateManager.stateID == 2) {
			renderer.material = material3;
		}
		if (StateManager.stateID == 3) {
			renderer.material = material4;
		}
	
	}
}
