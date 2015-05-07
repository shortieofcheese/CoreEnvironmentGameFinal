﻿using UnityEngine;
using System.Collections;

public class doorAnimation : MonoBehaviour {
	
	public GameObject door;
	public bool isOpen = false;
	bool mousePressed;
	public bool lastDoor;
	bool canAnimate;

	void Start(){
		canAnimate = true;
	}

	void Update(){
		mousePressed = (Input.GetMouseButtonDown(0) ? true : false);
	}

	void OnLook(){
		if (mousePressed && canAnimate){
			StartCoroutine(letAnimation());
			if(!this.isOpen){
				door.GetComponent<Animation>().Play("door open");				
				this.isOpen = true;				
			}else if (!lastDoor){
				door.GetComponent<Animation>().Play("door close");
				this.isOpen = false;				
			}
		}
	}

	IEnumerator letAnimation(){
		canAnimate = false;
		yield return new WaitForSeconds(.7f);
		canAnimate = true;
	}

}

