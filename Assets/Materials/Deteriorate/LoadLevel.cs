using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

	public Transform Player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnLook() {
		if (Input.GetMouseButtonDown(0)) {


			PlayerController.position = Player.position;
			//PlayerController.rotation = Player.rotato;
			Application.LoadLevel(0);

		}
	}
}
