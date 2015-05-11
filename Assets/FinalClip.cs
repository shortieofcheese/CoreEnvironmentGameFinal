using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FinalClip : MonoBehaviour {

	bool canChangeBloom, switchedCameras;
	public Canvas canvasRenderer;

	public GameObject table, teacup;
	public Image panel;

	void Awake () {

		startMoving();
		table.SetActive(false);
		teacup.SetActive(false);

	}

	void Update(){

		if (GetComponent<UnityStandardAssets.ImageEffects.BloomAndFlares>().bloomIntensity < 140f && canChangeBloom){
			GetComponent<UnityStandardAssets.ImageEffects.BloomAndFlares>().bloomIntensity += 0.1f;
		}

		if (GetComponent<UnityStandardAssets.ImageEffects.BloomAndFlares>().bloomIntensity >= 140f && !switchedCameras){
			switchedCameras = true;
			canvasRenderer.GetComponent<Canvas>().worldCamera = this.gameObject.GetComponent<Camera>();
			panel.CrossFadeAlpha(1f, 2f, false);
		}

	}

	void startMoving(){

		Invoke("iTweenMoveCamera", 2f);

	}

	void iTweenMoveCamera(){
		iTween.MoveTo(this.gameObject, iTween.Hash("y", 4.1f, "time", 13f, "easetype", iTween.EaseType.linear, "onstart", "doTheStuff", "onstarttarget", gameObject));
	}

	void doTheStuff(){

		Invoke("changeBloom", 2f);

	}

	void changeBloom(){

		canChangeBloom = true;

	}



}
