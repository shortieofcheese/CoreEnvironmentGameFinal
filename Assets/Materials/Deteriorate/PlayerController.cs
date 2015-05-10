using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	static public Vector3 position = new Vector3(0.452f,.69f,-5.8f);
	static public Vector3 rotation = Vector3.zero;

	public new Transform camera;

	public bool cam;
	// Use this for initialization
	void Start () {

		transform.position = position;
		transform.eulerAngles = new Vector3(0,rotation.y,0);	
	}
	
	// Update is called once per frame
	void Update () {

			rotation = camera.eulerAngles;


	}
}
