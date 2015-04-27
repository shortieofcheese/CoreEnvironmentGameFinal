using UnityEngine;
using System.Collections;

public class nightStandAnimation : MonoBehaviour {

	public GameObject drawer;
	public bool isOpen = false;
	bool mousePressed;

	void Update(){
		mousePressed = (Input.GetMouseButtonDown(0) ? true : false);
	}

	//Aninimation that opens and closes the nightstand drawer on mouse click.
	void OnLook(){

		if (mousePressed){
			if(!this.isOpen){
				
				drawer.GetComponent<Animation>().Play("Night Stand Open");
				
				this.isOpen = true;
				
			}else{
				drawer.GetComponent<Animation>().Play("Night Stand Close");
				
				this.isOpen = false;
				
			}
		}



	}

}
