using UnityEngine;
using System.Collections;

public class TeaCupAnimation : MonoBehaviour {

	public GameObject player;
	bool clicked;

	public GameObject finalCamera;

	void OnLook(){

		Debug.Log ("teacup");

		if (Input.GetMouseButtonDown(0) && !clicked){
			clicked = true;
			player.SetActive(false);
			finalCamera.SetActive(true);
		}
	}
}
