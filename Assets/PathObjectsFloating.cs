using UnityEngine;
using System.Collections;

public class PathObjectsFloating : MonoBehaviour {

	public float yPositionAnimation;
	public string objectName;
	bool entered;

	// Use this for initialization
	void Start () {

		objectName = this.gameObject.name;
		iTween.MoveTo(this.gameObject, iTween.Hash("name", objectName, "y", yPositionAnimation, "time", 2f, "easetype", iTween.EaseType.easeInOutSine, "looptype", iTween.LoopType.pingPong));

	}

	void OnTriggerEnter(Collider obj){
		if (obj.gameObject.tag == "Player" && !entered){
			entered = true;
			iTween.StopByName(objectName);
			iTween.MoveTo(this.gameObject, iTween.Hash("y", 6f, "time", 3f, "easetype", iTween.EaseType.easeInOutSine));
		}
	}
	


}
