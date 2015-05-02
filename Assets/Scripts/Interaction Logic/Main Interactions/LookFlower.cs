using UnityEngine;
using System.Collections;

public class LookFlower : MonoBehaviour {

	MakeFade mf;
	bool looked;
	
	// Use this for initialization
	void Start () {
		mf = GameObject.Find("_Game Manager").GetComponent<MakeFade>();
	}
	
	void OnLook(){
		
		if (Input.GetMouseButton(0) && !looked){
			looked = true;
			StartCoroutine(lookEventRoutine());
		}
		
	}
	
	IEnumerator lookEventRoutine(){
		yield return new WaitForSeconds(0.5f);
		mf.FadeInToScene(1.5f, 5);
	}
}
