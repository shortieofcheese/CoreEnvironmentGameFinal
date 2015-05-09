using UnityEngine;
using System.Collections;
namespace UnityStandardAssets.Characters.FirstPerson
{

public class UIManager : MonoBehaviour {
	
	static public bool isLooking;
	static public bool canRotate;

	static public GameObject narrativeObject;
	static public Transform lastPosition;

	static public GameObject target;
	public GameObject _target;

	public float RotationSpeed = 100;
	
	static public FirstPersonController _player;
	FirstPersonController player;

	bool pressed;

	void Start(){
		target = _target;
		player = GameObject.Find("FPSController").GetComponent<FirstPersonController>();
		_player = player;
	}

	void Update () {

		Debug.Log (lastPosition);
		pressed = (Input.GetMouseButtonDown(0) ? true : false);

		if(canRotate){
			narrativeObject.transform.Rotate((Input.GetAxis("Mouse Y") * RotationSpeed), 
				                 (Input.GetAxis("Mouse X") * RotationSpeed ), 0, Space.Self);

			if (pressed){
				letPlayerRotate();
				iTween.MoveTo(narrativeObject, iTween.Hash(
						"position", lastPosition,
						"time", 1f,
						"easetype", iTween.EaseType.easeOutQuint,
						"oncomplete", "makePlayerMove",
						"oncompletetarget", gameObject
						));
				iTween.RotateTo(narrativeObject, iTween.Hash(
						"rotation", lastPosition,
						"time", 1f,
						"easetype", iTween.EaseType.easeOutQuint
						));

			}
		}
	}
	
	public void startMovement(){
		isLooking = true;
		_player.enabled = false;
		iTween.MoveTo(narrativeObject, iTween.Hash(
				"position", target.transform.position,
				"time", 1f,
				"easetype", iTween.EaseType.easeOutQuint,
				"oncomplete", "letPlayerRotate",
				"oncompletetarget", gameObject
				));
		
	}
	
	public void letPlayerRotate(){
			canRotate = !canRotate;
	}

	public void makePlayerMove(){
		_player.enabled = true;
		isLooking = false;
		if (!narrativeObject.GetComponent<NarrativeObjectInteraction>().found){
			StateManager.objectsFound++;
			narrativeObject.GetComponent<NarrativeObjectInteraction>().found = true;	
		}
	}

}
}