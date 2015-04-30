using UnityEngine;
using System.Collections;

public class TurnOffLight : MonoBehaviour {

	public GameObject pointLight;
	MakeFade mf;

	bool lightOff;

	void Start(){

		mf = GameObject.Find("_Game Manager").GetComponent<MakeFade>();

	}

	void OnLook(){

		if (Input.GetMouseButton(0) && !lightOff){

			lightOff = true;
			StartCoroutine(lightEventRoutine());
		}

	}

	IEnumerator lightEventRoutine(){
		pointLight.SetActive(false);
		yield return new WaitForSeconds(1f);
		mf.FadeInToScene(1.5f, 1);
	}



}
