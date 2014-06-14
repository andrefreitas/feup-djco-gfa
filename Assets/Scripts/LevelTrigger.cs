using UnityEngine;
using System.Collections;

public class LevelTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col) {

		Application.LoadLevel ("piso1");

	}
}
