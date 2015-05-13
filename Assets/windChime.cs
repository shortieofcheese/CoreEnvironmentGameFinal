using UnityEngine;
using System.Collections;

public class windChime : MonoBehaviour {

	void FixedUpdate()
	{

		Rigidbody wind = GetComponent<Rigidbody>();

		Vector3 windDirection = new Vector3 (Random.Range(-1,1),Random.Range(-1,1),Random.Range(-1,1));
		float windMin = -.1f;
		float windMax = .1f;
		float windFrequency = .5f;
		float currentWindForce = windMin*.01f;
		
		wind.AddForce(currentWindForce * windDirection );
	}
}
