using UnityEngine;
using System.Collections;

public class Lamp : MonoBehaviour {

	public Material material1;
	public Material material2;
	public Light lampLight;
	AudioSource audio;

	bool lightOn;

	new Renderer renderer;

	void Start () {
		audio = GetComponent<AudioSource>();
		renderer = GetComponent<Renderer>();

	}

	void Update () {

		if(lightOn == true){
			renderer.material = material1;
			//StartCoroutine (Beat());
		}

		if(lightOn == false){
			//StopCoroutine(Beat());
			renderer.material = material2;
		}
	
	}
	void OnLook(){
		
		if (Input.GetMouseButtonDown(0)){

			if (lightOn){
				StopCoroutine(Beat());
				audio.Stop();
				lampLight.enabled = false;
				lightOn = false;

			}else if (!lightOn){
				StartCoroutine (Beat());
				lampLight.enabled = true;
				lightOn = true;
			}
		}
		
	}

	IEnumerator Beat()
	{
			audio.Play();
			yield return new WaitForSeconds(20.0f);
			audio.Stop();
			lightOn = false;

	}

}
