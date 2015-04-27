using UnityEngine;
using System.Collections;

public class doorAnimation : MonoBehaviour {
	
	public GameObject door;
	public bool isOpen = false;
	bool mousePressed;

	void Update(){

		mousePressed = (Input.GetMouseButtonDown(0) ? true : false);

	}

	//Animation that opens and closes the home doors on mouse click.
	void OnLook(){

		if (mousePressed){

			if(!this.isOpen){
				
				door.GetComponent<Animation>().Play("door open");
				
				this.isOpen = true;
				
			}else{
				door.GetComponent<Animation>().Play("door close");
				
				this.isOpen = false;
				
			}

		}

		
	}

}

