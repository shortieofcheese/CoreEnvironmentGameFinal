using UnityEngine;
using System.Collections;

public class HouseCinematic : MonoBehaviour {

	public Transform cameraFocus;
	public float time1, time2;
	public Vector3 cameraPosition;
	
	// Use this for initialization
	void Start () {
		iTween.MoveTo(this.gameObject, iTween.Hash ("path", iTweenPath.GetPath("Cinematic1"), "time", time1, "easetype", iTween.EaseType.linear, "looptype", iTween.LoopType.none, "oncomplete", "nextCut", "oncompletetarget", gameObject));
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.LookAt(cameraFocus);
	
	}

	void nextCut(){
		Camera.main.transform.position = cameraPosition;
		iTween.MoveTo(this.gameObject, iTween.Hash ("path", iTweenPath.GetPath("Cinematic2"), "time", time2, "easetype", iTween.EaseType.linear, "looptype", iTween.LoopType.none));
	}


}
