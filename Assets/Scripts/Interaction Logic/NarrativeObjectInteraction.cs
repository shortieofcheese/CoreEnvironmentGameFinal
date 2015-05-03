using UnityEngine;
using System.Collections;

public class NarrativeObjectInteraction : MonoBehaviour {

	//armazenar posicao inicial do objeto
	Transform startTransform;
	bool pressed;
	bool found;

	public Transform Player;


	void Start(){
		startTransform = this.transform;
	}

	void OnLook(){
		pressed = (Input.GetMouseButtonDown(0) ? true : false);

		if (pressed & !found){
			found = true;
			StateManager.objectsFound++;
			if (StateManager.objectsFound >= 3){
				PlayerController.position = Player.position;
				Application.LoadLevel(1);
			}
		}

	}

}
