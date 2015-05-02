using UnityEngine;
using System.Collections;

public class SitSofa : MonoBehaviour {

	MakeFade mf;
	bool areSit;
	
	// Use this for initialization
	void Start () {
		mf = GameObject.Find("_Game Manager").GetComponent<MakeFade>();
	}
	
	void OnLook(){
		
		if (Input.GetMouseButton(0) && !areSit){
			areSit = true;
			StartCoroutine(sitEventRoutine());
		}
		
	}
	
	IEnumerator sitEventRoutine(){
		yield return new WaitForSeconds(0.5f);
		mf.FadeInToScene(1.5f, 4);
	}
}
