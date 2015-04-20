using UnityEngine;
using System.Collections;

public class doorAnimation : MonoBehaviour {
	
	public GameObject door;
	public bool isOpen = false;

	//Animation that opens and closes the home doors on mouse click.

	void OnMouseDown(){
		
		if(!this.isOpen){
			
			door.GetComponent<Animation>().Play("door open");
			
			this.isOpen = true;
			
		}else{
			door.GetComponent<Animation>().Play("door close");
			
			this.isOpen = false;
			
		}
		
	}

}

