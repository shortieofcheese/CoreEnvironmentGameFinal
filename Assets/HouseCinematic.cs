using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HouseCinematic : MonoBehaviour {

	public Transform cameraFocus;
	public float time1, time2;
	public Vector3 cameraPosition;
	public GameObject player;
	public Camera playerCamera;
	public Canvas canvasRenderer;

	MakeFade mf;


	// Use this for initialization
	void Start () {

		mf = GameObject.Find("_Game Manager").GetComponent<MakeFade>();

		iTween.MoveTo(this.gameObject, iTween.Hash ("path", iTweenPath.GetPath("Cinematic1"),
		                                            "time", time1, 
		                                            "easetype", iTween.EaseType.linear,
		                                            "looptype",	iTween.LoopType.none,
		                                            "oncomplete", "nextCut",
		                                            "oncompletetarget", gameObject));
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.LookAt(cameraFocus);
	
	}

	void nextCut(){
		Camera.main.transform.position = cameraPosition;
		iTween.MoveTo(this.gameObject, iTween.Hash ("path", iTweenPath.GetPath("Cinematic2"),
		                                            "time", time2,
		                                            "easetype", iTween.EaseType.linear,
		                                            "looptype", iTween.LoopType.none,
		                                            "onstart", "switchCoroutine",
		                                            "onstarttarget", gameObject,
		                                            "oncomplete", "startPlayer",
		                                            "oncompletetarget", gameObject));
	}

	void switchCoroutine(){

		StartCoroutine(switchCamerasWithFade());
	}

	void startPlayer(){

		canvasRenderer.GetComponent<Canvas>().worldCamera = playerCamera;
		player.SetActive(true);
		this.gameObject.SetActive(false);

	}

	IEnumerator switchCamerasWithFade (){
		yield return new WaitForSeconds(time2 - 2f);
		mf.FadeInOut();
	}


}
