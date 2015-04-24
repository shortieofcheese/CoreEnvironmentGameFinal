using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public Transform cube;

	// Use this for initialization
	void Start () {
			
		iTween.MoveTo(this.gameObject, iTween.Hash ("path", iTweenPath.GetPath("Move"), "time", 20f));


	}
	
	// Update is called once per frame
	void Update () {

		transform.LookAt(cube);

	
	}
}
