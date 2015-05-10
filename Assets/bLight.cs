using UnityEngine;
using System.Collections;

public class bLight : MonoBehaviour {
	
	public Material material1;
	public Material material2;
	public Light lampLight;
	public Light lampLight2;
	public Renderer lightRend;
	
	bool lightOn;
	
	void Start () {

	}
	
	void Update () {
		
		if(lightOn == true){
			lightRend.material = material1;
		}
		
		if(lightOn == false){
			lightRend.material = material2;
		}
		
	}
	void OnLook(){
		
		if (Input.GetMouseButtonDown(0)){
			if (lightOn){
				
				lampLight.enabled = false;
				lampLight2.enabled = false;
				lightOn = false;

			}else if (!lightOn){
				lampLight.enabled = true;
				lampLight2.enabled = true;
				lightOn = true;
			}
		}
		
	}
	
}
