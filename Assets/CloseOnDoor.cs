using UnityEngine;
using System.Collections;

public class CloseOnDoor : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {

		iTween.MoveTo(this.gameObject, iTween.Hash ("path", iTweenPath.GetPath("CloseOnDoor"), "time", 5f));
		StartCoroutine(makePlayer());
	}

	IEnumerator makePlayer(){
		yield return new WaitForSeconds(5f);
		Debug.Log ("stuff");
		player.SetActive(true);
		this.gameObject.SetActive(false);

	}


}
