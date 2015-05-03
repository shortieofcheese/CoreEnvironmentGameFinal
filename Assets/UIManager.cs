using UnityEngine;
using System.Collections;
namespace UnityStandardAssets.Characters.FirstPerson
{

public class UIManager : MonoBehaviour {
	
	bool isLooking;
	public GameObject canvasImage;
	public float RotationSpeed = 100;

	void Update () {

		FirstPersonController player = GameObject.Find("FPSController").GetComponent<FirstPersonController>();

		if(Input.GetMouseButtonDown(0)){
				if(isLooking == true){
					isLooking = false;
				}else{
					isLooking = true;
				}
		}
			if(isLooking){
				player.enabled = false;
				canvasImage.transform.Rotate((Input.GetAxis("Mouse X") * RotationSpeed), 
				                 (Input.GetAxis("Mouse Y") * RotationSpeed ), 0, Space.World);
				canvasImage.SetActive(true);

			}else{
				player.enabled = true;
				canvasImage.SetActive(false);

			}



	}
}
}