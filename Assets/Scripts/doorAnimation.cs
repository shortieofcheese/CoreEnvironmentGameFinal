using UnityEngine;
using System.Collections;

public class doorAnimation : MonoBehaviour {
	
	public GameObject door;
	public bool isOpen = false;
	bool mousePressed;
	public bool lastDoor;
	bool canAnimate;
	AudioSource audio;

	void Start(){
		canAnimate = true;
		audio = GetComponent<AudioSource>();
	}

	void Update(){
		mousePressed = (Input.GetMouseButtonDown(0) ? true : false);
	}

	void OnLook(){
		if (mousePressed && canAnimate){
			StartCoroutine(letAnimation());
			if(!this.isOpen){
				door.GetComponent<Animation>().Play("door open");
				audio.Play();
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

