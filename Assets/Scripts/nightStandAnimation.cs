using UnityEngine;
using System.Collections;

public class nightStandAnimation : MonoBehaviour {

	public GameObject drawer;
	public bool isOpen = false;

	//Aninimation that opens and closes the nightstand drawer on mouse click.

	void OnMouseDown(){

		if(!this.isOpen){

			drawer.GetComponent<Animation>().Play("Night Stand Open");

			this.isOpen = true;

		}else{
			drawer.GetComponent<Animation>().Play("Night Stand Close");

			this.isOpen = false;

		}

	}

}
