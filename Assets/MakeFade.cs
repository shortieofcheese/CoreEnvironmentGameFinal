using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MakeFade : MonoBehaviour {

	public Image panel;

	void Start(){
		panel.CrossFadeAlpha(0f, 2f, false);
	}

	public void FadeInToScene(float d, int s){
		StartCoroutine(FadeInToOtherScene(d,s));
	}


	IEnumerator FadeInToOtherScene (float duration, int scene){
		panel.CrossFadeAlpha(1f, duration, false);
		yield return new WaitForSeconds(duration + 0.5f);
		Application.LoadLevel(scene);
	}

}
