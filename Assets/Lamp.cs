using UnityEngine;
using System.Collections;

public class Lamp : MonoBehaviour {

	public Material material1;
	public Material material2;
	public Light lampLight;

	bool lightOn;

	new Renderer renderer;

	void Start () {
	
		renderer = GetComponent<Renderer>();

	}

	void Update () {

		if(lightOn == true){
			renderer.material = material1;
		}

		if(lightOn == false){
			renderer.material = material2;
		}
	
	}
	void OnLook(){
		
		if (Input.GetMouseButtonDown(0)){
			if (lightOn){
				
				lampLight.enabled = false;
				lightOn = false;
			}else if (!lightOn){
				lampLight.enabled = true;
				lightOn = true;
			}
		}
		
	}

}
