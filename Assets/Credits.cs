using UnityEngine;
using System.Collections;

public class Credits : MonoBehaviour {

	bool crawling;
	float speed;

	void Start () {
	

	}

	void credits () {
		crawling = true;
		speed = .03f;
	}

	// Update is called once per frame
	void Update () {

			if (!crawling)
				return;
			transform.Translate(Vector3.up * Time.deltaTime * speed);
		}
	
}
