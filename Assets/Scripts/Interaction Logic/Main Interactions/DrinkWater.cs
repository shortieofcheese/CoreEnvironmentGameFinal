using UnityEngine;
using System.Collections;

public class DrinkWater : MonoBehaviour {

	MakeFade mf;
	bool drinked;

	// Use this for initialization
	void Start () {
		mf = GameObject.Find("_Game Manager").GetComponent<MakeFade>();
	}
	
	void OnLook(){
		
		if (Input.GetMouseButton(0) && !drinked){
			drinked = true;
			StartCoroutine(drinkEventRoutine());
		}
		
	}
	
	IEnumerator drinkEventRoutine(){
		yield return new WaitForSeconds(0.5f);
		mf.FadeInToScene(1.5f, 3);
	}

}
