using UnityEngine;
using System.Collections;

public class auxCam : MonoBehaviour {

	public GameObject thingToFollow;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.rotation = thingToFollow.transform.rotation;
	
	}
}
