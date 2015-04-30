using UnityEngine;
using System.Collections;
namespace UnityStandardAssets.Characters.FirstPerson
{

public class UIManager : MonoBehaviour {
	
	bool isLooking;
	public GameObject canvasImage;

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
				canvasImage.SetActive(true);

			}else{
				player.enabled = true;
				canvasImage.SetActive(false);

			}



	}
}
}