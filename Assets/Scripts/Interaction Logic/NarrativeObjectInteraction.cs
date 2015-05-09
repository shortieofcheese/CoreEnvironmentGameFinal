using UnityEngine;
using System.Collections;
namespace UnityStandardAssets.Characters.FirstPerson
{

public class NarrativeObjectInteraction : MonoBehaviour {
	
	public GameObject target;
	UIManager ui;
	public Transform myTransform;

	bool pressed;
	public bool found;

	void Start(){
		ui = GameObject.Find("Game Manager").GetComponent<UIManager>();
	}

	void OnLook(){
		pressed = (Input.GetMouseButtonDown(0) ? true : false);

		if (pressed && !UIManager.isLooking){
			UIManager.narrativeObject = this.gameObject;
			UIManager.lastPosition = myTransform;
			ui.startMovement();
		}

	}

	

}

}
