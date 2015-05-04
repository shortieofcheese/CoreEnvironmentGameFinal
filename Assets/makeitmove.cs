using UnityEngine;
using System.Collections;

public class makeitmove : MonoBehaviour {

	public GameObject target;

	// Use this for initialization
	void Start () {
		iTween.MoveTo(target, iTween.Hash(
			"time", 1f
			//"easetype", iTween.EaseType.easeOutQuint
			//"oncomplete", "UIManager.letPlayerRotate"
			));


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
