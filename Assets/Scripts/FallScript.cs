using UnityEngine;
using System.Collections;

public class FallScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col) {
		if(LivesScript.DecreaseLives())
			Application.LoadLevel (Application.loadedLevel);
		
		else Application.LoadLevel ("intro");
	}
}
