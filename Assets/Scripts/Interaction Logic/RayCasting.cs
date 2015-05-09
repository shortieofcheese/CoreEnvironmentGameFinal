using UnityEngine;
using System.Collections;

public class RayCasting : MonoBehaviour {

	public LayerMask raycastMask;

	public string functionToCallOnLook = "OnLook";
	
	// Update is called once per frame
	void Update () {
		Ray ray = new Ray( transform.position, transform.forward);
		RaycastHit rayHit = new RaycastHit();

		if ( Physics.Raycast ( ray, out rayHit, 1.25f, raycastMask ) ) {
			rayHit.transform.SendMessage ( functionToCallOnLook, SendMessageOptions.DontRequireReceiver );
		}
	}
}