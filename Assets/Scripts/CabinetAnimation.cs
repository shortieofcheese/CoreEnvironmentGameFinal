using UnityEngine;
using System.Collections;

public class CabinetAnimation : MonoBehaviour {
	
	public GameObject cabinet;
	public bool isOpen = false;
	bool mousePressed;
	
	void Update(){
		
		mousePressed = (Input.GetMouseButtonDown(0) ? true : false);
		
	}
	
	//Animation that opens and closes the home doors on mouse click.
	void OnLook(){
		
		if (mousePressed){
			
			if(!this.isOpen){
				
				cabinet.GetComponent<Animation>().Play("CabinetOpen");
				
				this.isOpen = true;
				
			}else{
				cabinet.GetComponent<Animation>().Play("CabinetClose");
				
				this.isOpen = false;
				
			}
			
		}
		
	}
	
}