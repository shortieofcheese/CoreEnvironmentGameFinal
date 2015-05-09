using UnityEngine;
using System.Collections;

public class AsteroidMovementCamea : MonoBehaviour {



	// Use this for initialization
	void Start () {

		iTween.MoveBy(this.gameObject, iTween.Hash("z" , -200f, "speed", .2f, "easetype", iTween.EaseType.linear));
		iTween.RotateBy(this.gameObject, iTween.Hash("z", 1f, "time", 10f , "easetype", iTween.EaseType.linear, "looptype", iTween.LoopType.loop));
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
