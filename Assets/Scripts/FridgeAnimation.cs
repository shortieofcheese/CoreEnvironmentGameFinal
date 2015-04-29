using UnityEngine;
using System.Collections;

public class FridgeAnimation : MonoBehaviour {
	
	public GameObject fridge;
	public bool isOpen = false;
	bool mousePressed;
	
	void Update(){
		
		mousePressed = (Input.GetMouseButtonDown(0) ? true : false);
		
	}
	
	//Animation that opens and closes the home doors on mouse click.
	void OnLook(){
		
		if (mousePressed){
			
			if(!this.isOpen){
				
				fridge.GetComponent<Animation>().Play("FridgeDoorOPEN");
				
				this.isOpen = true;
				
			}else{
				fridge.GetComponent<Animation>().Play("FridgeDoorCLOSE");
				
				this.isOpen = false;
				
			}
			
		}
		
	}
	
}
